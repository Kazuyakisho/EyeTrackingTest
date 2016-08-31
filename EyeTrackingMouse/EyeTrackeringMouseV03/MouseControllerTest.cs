using System;
using System.Windows.Forms;
using EyeTrackingMouseV03Lib.MouseController;

namespace MouseControllerTest
{
    public partial class MouseControllerTest : Form
    {
        public MouseControllerTest()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (CommandsBox.SelectedItem != null)
                ExecutionBox.Items.Add(CommandsBox.SelectedItem);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = ExecutionBox.SelectedIndices.Count - 1; i >= 0; i--)
                ExecutionBox.Items.RemoveAt(ExecutionBox.SelectedIndices[i]);
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ExecutionBox.Items.Count; i++)
                switch(ExecutionBox.Items[i].ToString())
                {
                    case "Up": MouseController.Move(0, -100); break;
                    case "Down": MouseController.Move(0, 100); break;
                    case "Left": MouseController.Move(-100, 0); break;
                    case "Right": MouseController.Move(100, 0); break;
                    case "LeftClick": MouseController.LeftClick(); break;
                    case "RightClick": MouseController.RightClick(); break;
                    case "LeftUp": MouseController.LeftUp(); break;
                    case "RightUp": MouseController.RightUp(); break;
                    case "LeftDown": MouseController.LeftDown(); break;
                    case "RightDown": MouseController.RightDown(); break;
                    case "WheelUp": MouseController.WheelUp(); break;
                    case "WheelDown": MouseController.WheelDown(); break;
                }
        }
    }
}
