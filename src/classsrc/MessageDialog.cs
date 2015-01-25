using System.Windows.Forms;

namespace WindowsFormsApplication1
{   
    public static class MessageDialog
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void ErrorMessageBox(string message)
        {
            ShowMessageBox(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void InfoMessageBox(string message)
        {
            ShowMessageBox(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void WarningMessageBox(string message)
        {
            ShowMessageBox(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public static void QuestionMessageBox(string message)
        {
            ShowMessageBox(message, "Are you sure?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="messageBoxContent"></param>
        /// <param name="messageBoxTitle"></param>
        /// <param name="messageBoxButton"></param>
        /// <param name="messageBoxIcon"></param>
        private static void ShowMessageBox(string messageBoxContent, string messageBoxTitle, MessageBoxButtons messageBoxButton, MessageBoxIcon messageBoxIcon)
        {
            MessageBox.Show(null, messageBoxContent, messageBoxTitle, messageBoxButton, messageBoxIcon);
        }
    }
}
