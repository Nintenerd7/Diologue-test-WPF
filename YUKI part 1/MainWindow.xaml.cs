using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YUKI_part_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// yuki
        String[] array = new String[5] { "Now we have three of the shards. what is next?", "I see. hey look at the stars. they are in a line directing where you should go. why not use your wand to make a lense.", "Your gonna make a great grand high wizard one day.", "what is it Shido?", "Okay you can tell me later."};
        /// 
        /// </summary>
        //shidos script
        String[] array2 = new String[5] { "We need to find the purple shard thats hidden within the mountains. As its the solcice we can now identify a path to it.", "Well come to think of it I was thinking the same thing. I can use my wand to create a lense of truth.", "woah- uh thanks...", "Yuki I have something to tell you.", "nevermind.. lets just get to business." };
        //

        int pos;

        public MainWindow()
        {
             
            InitializeComponent();

            Ymsg.Text = array[0];
        }

        private void Abtn_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 5; ++i)
            {
                Ymsg.Text = "";
                Smsg.Text = array2[0];
                pos = pos + 1;
            }
        }
    }
}
