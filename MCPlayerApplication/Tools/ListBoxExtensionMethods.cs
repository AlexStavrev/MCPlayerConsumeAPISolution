using System.Windows.Forms;

namespace MCPlayerApplication.Tools
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
    }
}
