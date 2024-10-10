using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Umrah.Code.Helper
{
    public static class MessageCollections
    {
        // Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Properties.Resources.EmptyMessageText, Properties.Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorServer()
        {
            MessageBox.Show(Properties.Resources.ServerErrorText, Properties.Resources.ServerErrorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowFieldsRequired()
        {
            MessageBox.Show(Properties.Resources.FieldsReqText, Properties.Resources.FieldReqCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowRequiredDeleteRow()
        {
            MessageBox.Show(Properties.Resources.ShowReDeleteFiledText, Properties.Resources.ShowReDeleteFiledCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Dialog
        public static bool ShowDeleteDialog()
        {
            var result = MessageBox.Show(Properties.Resources.DeleteDialogText, Properties.Resources.DeleteDialogCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Notifications
        public static void ShowAddNotification()
        {
            Gui.NotificationGui.NotificationForm notificationForm = new Gui.NotificationGui.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الإضافة بنجاح.";
            notificationForm.Show();
        }
        public static void ShowUpdateNotification()
        {
            Gui.NotificationGui.NotificationForm notificationForm = new Gui.NotificationGui.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية التعديل بنجاح.";
            notificationForm.Show();
        }
        public static void ShowDeleteNotification()
        {
            Gui.NotificationGui.NotificationForm notificationForm = new Gui.NotificationGui.NotificationForm();
            notificationForm.labelTitle.Text = "تمت عملية الإزالة بنجاح.";
            notificationForm.Show();
        }
    }
}
