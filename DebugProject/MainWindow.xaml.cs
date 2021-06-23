using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Threading;
using DebugProject.Models;
using System.IO;

namespace DebugProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            HiddenSombra();
            BunnyForDva.Visibility = Visibility.Hidden;
            DVA_Sprite.Visibility = Visibility.Hidden;
            OrcDeathSprite.Visibility = Visibility.Hidden;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SombraSprite.Visibility = Visibility.Visible;
            OrcEnemySprite.Visibility = Visibility.Visible;
            BlinkShot(ShotSprite, BloodSprite);

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        //сдедлать нажатие через кнопку клавиатуры
            SombraSprite.Visibility = Visibility.Visible;
            OrcEnemySprite.Visibility = Visibility.Visible;
            string DvaSup = "D.VA Help me!!!";
            SombraText.Text = $"{DvaSup}...";
            DeleteText(SombraText);
            DVAsummon(DVA_Sprite);



            //OrcDialogue()
        }


        private async Task DeleteText(TextBlock SombraText)
        {
            await Task.Delay(3000);
            SombraText.Text = " ";

        }

        public async Task DVAsummon(Image DVA_Sprite)
        {
            //bool isDvaInBattle = IsDvaInBattle;
            //IsDvaInBattle = true;
            DVA_Sprite.Visibility = Visibility.Visible;
            await Task.Delay(5000);
            DVA_Sprite.Visibility = Visibility.Hidden;
            await Task.Delay(2000);
        }

        // метод Task >> (тут обращенее к типу)
        private async Task BlinkShot(Image shortSprite, Image bloodSprite)
        {
            //разделить на два метода

            for (int i = 0; i < 20; i++)
            {
                shortSprite.Visibility = Visibility.Visible;
                bloodSprite.Visibility = Visibility.Visible;
                await Task.Delay(50);
                shortSprite.Visibility = Visibility.Hidden;
                bloodSprite.Visibility = Visibility.Hidden;
                await Task.Delay(50);

                if (i >= 19)
                {
                    Random rnd = new Random();
                    int damRandom = rnd.Next(50, 100);
                    //int damRandom = rand;

                    string InfoForSombra = $"Damage = {damRandom}";
                    //await Task.Delay(500);
                    if (damRandom >= 70)
                    {
                        //экземпляр класса
                        EnemyOrcsNew Orc_1 = new EnemyOrcsNew();
                        Orc_1.name = "Eliatrope";
                        Orc_1.orcMessage = "Zug-zug";
                        Orc_1.IsDeath = true;
                        OrcEnemySprite.Visibility = Visibility.Hidden;
                        OrcDeathSprite.Visibility = Visibility.Visible;

                        InfoForSombra = $"Damage = {damRandom} >>> Critical Damage <<< \n Orc Ready: {Orc_1.name} > {Orc_1.orcMessage}";

                    }
                    //else if
                    //{

                    //}
                    InfoSombra.Text = ($"{InfoForSombra}");

                }


            }
        }

        // Создать Экземпляр Класса для орка (HP)
        // попробовать сделать Конструктор класса 

        private void HiddenSombra()
        {
            SombraSprite.Visibility = Visibility.Hidden;
            ShotSprite.Visibility = Visibility.Hidden;
            OrcEnemySprite.Visibility = Visibility.Hidden;
            BloodSprite.Visibility = Visibility.Hidden;

        }

        //вызов данныъ о протвивнике Орк
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            //BlinkShot(ShotSprite, BloodSprite);

            // Create Image Element

            Image myImage = new Image();
            myImage.Width = 200;

            // Create source
            BitmapImage myBitmapImage = new BitmapImage();

            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@"C:\Users\ABondarenko\sourceMy\DebugProject\DebugProject\OrcEnemy.png");
            myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();
            //set image source
            OrcSprite.Source = myBitmapImage;

            
     

            //связь с базой и забор данных

            using (NpcDatasDBContext db = new NpcDatasDBContext())
            {
                var NpcData = db.NpcDatas.ToList();
                string InfoOrc = "Будет инфа";
                OrcData.Text = $"{InfoOrc} -";



                foreach (NpcData u in NpcData)
                {
                    OrcData.Text = $" Datas - \n {u.Health}  \n {u.Armor} \n {u.MessageInBattle} \n{(u.Sprite)} ";

                }

            }



            //DVAsummon(DVA_Sprite);
        }

        public class EnemyOrcsNew
        {


            public string name;
            public bool IsDeath;
            public string orcMessage;

            //OrcEnemySprite.Visibility = Visibility.Visible;

            public void GetInfo()
            {
                Console.WriteLine($"Ork: {name} Death: {IsDeath} Orc Message {orcMessage}");

            }

        }
    }
}


