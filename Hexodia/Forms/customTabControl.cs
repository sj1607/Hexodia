using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexodia.Forms
{
    public class customTabControl : MetroTabControl
    {
        /// <summary>
        /// Customizes the painting of the control by overriding the OnPaint method.
        /// It clears the background and customizes the tab rendering by coloring the tabs based on selection state.
        /// </summary>
        /// <param name="e">The PaintEventArgs that contains information about the painting event, such as the graphics object used to draw.</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the base class OnPaint method to ensure any default painting behavior is applied.
            base.OnPaint(e);

            // Clear the background with a dark gray color (RGBA: 64, 64, 64).
            e.Graphics.Clear(Color.FromArgb(64, 64, 64));

            // Iterate through all the tab pages.
            for (int i = 0; i < TabPages.Count; i++)
            {
                // Get the rectangular area of the current tab.
                var tabRect = GetTabRect(i);

                // Set the tab color to gold for the selected tab, or white for unselected tabs.
                var tabColor = i == SelectedIndex ? Color.Gold : Color.White;

                // Create a solid brush with the selected tab color and fill the tab area.
                using (var brush = new SolidBrush(tabColor))
                {
                    e.Graphics.FillRectangle(brush, tabRect);
                }

                // Draw the tab text centered within the tab area.
                TextRenderer.DrawText(e.Graphics, TabPages[i].Text, Font, tabRect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

    }
}
