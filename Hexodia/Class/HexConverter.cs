using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexodia.Class
{
    public class HexConverter
    {
        /// <summary>
        /// Converts a string input to its corresponding hexadecimal representation based on the specified type.
        /// </summary>
        /// <param name="input">The input value to be converted (e.g., string, float, int, double).</param>
        /// <param name="type">The type of the input value, used to determine the conversion (can be "string", "float", "int", or "double").</param>
        /// <param name="isLittleEndian">Specifies whether the output should be little-endian or big-endian.</param>
        /// <returns>A hexadecimal string representation of the input value.</returns>
        /// <exception cref="ArgumentException">Thrown when the specified type is not supported.</exception>
        public string ConvertToHex(string input, string type, bool isLittleEndian)
        {
            byte[] bytes;

            // Determine how to convert the input based on the provided type.
            switch (type)
            {
                case "string":
                    bytes = Encoding.ASCII.GetBytes(input); // Convert string to bytes.
                    break;
                case "float":
                    bytes = BitConverter.GetBytes(float.Parse(input)); // Convert float to bytes.
                    break;
                case "int":
                    bytes = BitConverter.GetBytes(int.Parse(input)); // Convert int to bytes.
                    break;
                case "double":
                    bytes = BitConverter.GetBytes(double.Parse(input)); // Convert double to bytes.
                    break;
                default:
                    throw new ArgumentException("Type not supported"); // Throw exception if type is not supported.
            }

            // Reverse the byte array if the endianness does not match the system's byte order.
            if (BitConverter.IsLittleEndian == isLittleEndian && type != "string")
            {
                Array.Reverse(bytes); // Reverse the byte order for non-string types if necessary.
            }

            // Convert the byte array to a hex string, removing the hyphens.
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        /// <summary>
        /// Validates whether a string is a valid hexadecimal string (only contains characters 0-9 and A-F).
        /// </summary>
        /// <param name="hex">The hex string to validate.</param>
        /// <returns>True if the string is a valid hex string, otherwise false.</returns>
        public bool IsValidHexString(string hex)
        {
            // Check if the string matches the regex pattern for a valid hex string.
            return System.Text.RegularExpressions.Regex.IsMatch(hex, @"\A\b[0-9a-fA-F]+\b\Z");
        }

        /// <summary>
        /// Converts a hexadecimal string to a byte array.
        /// </summary>
        /// <param name="hex">The hex string to be converted.</param>
        /// <returns>A byte array representing the hex string.</returns>
        public byte[] HexStringToByteArray(string hex)
        {
            // Convert the hex string to a byte array by parsing each pair of characters as a byte.
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0) // Select every second character to form byte pairs.
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16)) // Convert each byte pair to a byte.
                             .ToArray(); // Return the byte array.
        }



    }
}
