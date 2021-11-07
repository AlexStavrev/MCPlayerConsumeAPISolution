using System.Windows.Forms;
using System.Linq;

namespace PlayerViewer.Tools
{
    public static class ListBoxExtensionMethods
    {
        public static void AddItemThreadSafe(this ListBox listBox, object item)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new MethodInvoker(delegate
                {
                    lock (listBox)
                    {
                        listBox.Items.Add(item);
                    }
                }));
            }
            else
            {
                lock (listBox)
                {
                    listBox.Items.Add(item);
                }
            }
        }

        public static void ClearThreadSafe(this ListBox listBox)
        {
            if (listBox.InvokeRequired)
            {
                listBox.Invoke(new MethodInvoker(delegate
                {
                    lock (listBox)
                    {
                        listBox.Items.Clear();
                    }
                }));
            }
            else
            {
                lock (listBox)
                {
                    listBox.Items.Clear();
                }
            }
        }
    }
}
