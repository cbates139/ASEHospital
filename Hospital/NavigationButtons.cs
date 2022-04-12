using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
    public class NavigationButtons
    {
        List<Button> buttons;
        Color defaultColour;
        Color selectedColour;

        public NavigationButtons(List<Button> buttons, Color defaultColour, Color selectedColour)
        {
            this.buttons = buttons;
            this.defaultColour = defaultColour;
            this.selectedColour = selectedColour;
        }

        private void SetButtonColour()
        {
            foreach(Button button in buttons)
            {
                button.BackColor = defaultColour;
            }
        }

        public void Highlight(Button selectedButton)
        {
            foreach (Button button in buttons)
            {
                if (button == selectedButton)
                    selectedButton.BackColor = selectedColour;
                else
                    button.BackColor = defaultColour;
            }
        }
    }
}
