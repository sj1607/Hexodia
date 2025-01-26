using Hexodia.Class;
using Microsoft.Win32;
using System.Text;


namespace Hexodia
{
    /// <summary>
    /// The main form of Hexodia .
    /// </summary>
    public partial class Hexodia : Form
    {
#nullable enable
        /// <summary>
        /// Handles hex conversion logic.
        /// </summary>
        private HexConverter hexConverter;
#nullable disable

        /// <summary>
        /// Stores the last mouse location for form dragging.
        /// </summary>
        private Point lastLocation;

        /// <summary>
        /// Indicates whether the form is being dragged.
        /// </summary>
        private bool isDragging = false;


        /// <summary>
        /// Initializes a new instance of the "Hexodia" class.
        /// </summary>
        public Hexodia()
        {
            InitializeComponent();
            hexConverter = new HexConverter();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            if(Properties.Settings.Default.runOnStartup)
            {
                runToggleButton.Checked = true;
            }


        }

        private void Hexodia_Load(object sender, EventArgs e)
        {

        }

        private void Hexodia_Paint(object sender, PaintEventArgs e)
        {


        }


        /// <summary>
        /// Draws a custom border around the form.
        /// </summary>
        /// <param name="e">The paint event arguments.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (Pen pen = new Pen(Color.Gold, 5))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        /// <summary>
        /// Exits the application when the exit button is clicked.
        /// </summary>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Minimizes the application when the minimize button is clicked.
        /// </summary>
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void customTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        // <summary>
        /// Copies the string representation to the clipboard.
        /// </summary>
        private void copyStringBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(stringTextBox.Text);
        }

        /// <summary>
        /// Copies the integer representation to the clipboard.
        /// </summary>
        private void copyIntBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(intTextBox.Text);
        }

        /// <summary>
        /// Copies the float representation to the clipboard.
        /// </summary>
        private void copyFloatBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(floatTextBox.Text);
        }

        /// <summary>
        /// Copies the double representation to the clipboard.
        /// </summary>
        private void copyDoubleBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(doubleTextBox.Text);
        }


        /// <summary>
        /// Handles input text changes and updates output fields based on hex conversion.
        /// </summary>
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            string hexInput = inputTextBox.Text.Trim();

            if (string.IsNullOrEmpty(hexInput))
            {
                ClearOutputs();
                return;
            }

            if (!hexConverter.IsValidHexString(hexInput))
            {
                MessageBox.Show("Invalid hexadecimal entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Convert hex to bytes
                byte[] bytes = hexConverter.HexStringToByteArray(hexInput);

                // String
                stringTextBox.Text = Encoding.ASCII.GetString(bytes);

                // Int (32-bit)
                if (bytes.Length >= 4)
                {
                    int intValue = BitConverter.ToInt32(bytes, 0);
                    intTextBox.Text = intValue.ToString();
                }

                // Float
                if (bytes.Length >= 4)
                {
                    float floatValue = BitConverter.ToSingle(bytes, 0);
                    floatTextBox.Text = floatValue.ToString();
                }

                // Double
                if (bytes.Length >= 8)
                {
                    double doubleValue = BitConverter.ToDouble(bytes, 0);
                    doubleTextBox.Text = doubleValue.ToString();
                }
            }
            catch (Exception ex)
            {
                 ClearOutputs();
            }
        }


        /// <summary>
        /// Clears all output fields.
        /// </summary>
        private void ClearOutputs()
        {
            stringTextBox.Text = "";
            intTextBox.Text = "";
            floatTextBox.Text = "";
            doubleTextBox.Text = "";
        }

        /// <summary>
        /// Determines whether the current endian setting is Little Endian.
        /// </summary>
        /// <returns>True if Little Endian is selected; otherwise, false.</returns>
        private bool IsLittleEndian()
        {
            return littleEndianRadioButton.Checked;
        }

        /// <summary>
        /// Handles value input text changes and updates the hex conversion output.
        /// </summary>
        private void inputValueTextBox_TextChanged(object sender, EventArgs e)
        {
            string selectedType = GetSelectedRadioButton();
            string inputValue = inputValueTextBox.Text.Trim();

            if (string.IsNullOrEmpty(inputValue))
            {
                outputTextBox.Text = string.Empty;
                return;
            }

            try
            {

                string hexResult = hexConverter.ConvertToHex(inputValue, selectedType, IsLittleEndian());
                outputTextBox.Text = hexResult;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conversion error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Retrieves the selected radio button value indicating the data type.
        /// </summary>
        /// <returns>The selected data type as a string.</returns>
        private string GetSelectedRadioButton()
        {
            if (stringRadioButton.Checked) return "string";
            if (floatRadioButton.Checked) return "float";
            if (intRadioButton.Checked) return "int";
            if (doubleRadioButton.Checked) return "double";
            return "string";
        }




        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bigEndianRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the MouseDown event for the logoPictureBox control.
        /// If the left mouse button is pressed, it enables the dragging mode and stores the current mouse location.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing information about the mouse event.</param>
        private void logoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true; // Enables dragging.
                lastLocation = e.Location; // Stores the current mouse location.
            }
        }

        /// <summary>
        /// Handles the MouseDown event for the Hexodia control.
        /// If the left mouse button is pressed, it enables the dragging mode and stores the current mouse location.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing information about the mouse event.</param>
        private void Hexodia_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true; // Enables dragging.
                lastLocation = e.Location; // Stores the current mouse location.
            }
        }

        /// <summary>
        /// Handles the MouseMove event for the logoPictureBox control.
        /// If dragging mode is enabled, it updates the position of the window based on mouse movement.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing information about the mouse event.</param>
        private void logoPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculates and sets the new position of the window.
                this.Location = new Point((this.Left - lastLocation.X) + e.X, (this.Top - lastLocation.Y) + e.Y);
            }
        }

        /// <summary>
        /// Handles the MouseMove event for the Hexodia control.
        /// If dragging mode is enabled, it updates the position of the window based on mouse movement.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing information about the mouse event.</param>
        private void Hexodia_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
                // Calculates and sets the new position of the window.
                this.Location = new Point((this.Left - lastLocation.X) + e.X, (this.Top - lastLocation.Y) + e.Y);
        }

        /// <summary>
        /// Handles the MouseUp event for the logoPictureBox control.
        /// When the mouse button is released, it disables dragging mode.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing information about the mouse event.</param>
        private void logoPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Disables dragging.
        }

        /// <summary>
        /// Handles the MouseUp event for the Hexodia control.
        /// When the mouse button is released, it disables dragging mode.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data containing information about the mouse event.</param>
        private void Hexodia_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false; // Disables dragging.
        }


        /// <summary>
        /// Toggles the application's behavior to run on Windows startup.
        /// </summary>
        private void runToggleButton_CheckedChanged(object sender, EventArgs e)
        {

            bool startWithWindows = runToggleButton.Checked;


            Properties.Settings.Default.runOnStartup = startWithWindows;
            Properties.Settings.Default.Save();


            if (startWithWindows)
            {

                AddToStartup();
            }
            else
            {

                RemoveFromStartup();
            }
        }

        /// <summary>
        /// Adds the application to Windows startup.
        /// </summary>
        private void AddToStartup()
        {
            string appName = "Hexodia";
            string appPath = Application.ExecutablePath;


            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);


            key.SetValue(appName, appPath);
        }

        /// <summary>
        /// Removes the application from Windows startup.
        /// </summary>
        private void RemoveFromStartup()
        {
            string appName = "Hexodia";


            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);


            key.DeleteValue(appName, false);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }


    }
}
