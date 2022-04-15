using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital
{
  
    public class NavigationControl
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;

        public NavigationControl(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            AddUserControlls();
        }

        private void AddUserControlls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                //Set every usercontrols dock style to fill so that it will occupy the space inside the panel
                userControlList[i].Dock = DockStyle.Fill;
                //Add all the usercontrol inside the panel
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < userControlList.Count())
            {
                userControlList[index].BringToFront(); // Display only the selected user control using index
            }
        }
    }
}
