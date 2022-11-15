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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        T_Users user;
        public Profile()
        {
            InitializeComponent();
            this.user = user;  // заполняем выше созданный объект информацией об авторизованном пользователе
            tbName.Text = user.Name;  // заполняем поле с именем
            tbSurname.Text = user.Surname;  // заполняем поле с фамилией
            List<Userphoto> u = ClassBase.BD.Userphoto.Where(x => x.idUser == user.idUser).ToList(); // для загрузки картинки находим все фото пользователя в таблице, где хранятся фото
            if (u != null)  // если список с фото не пустой, начинает переводить байтовый массив в изображение
            {
                byte[] Bar = u[u.Count - 1].photoBinary;   // считываем изображение из базы (считываем байтовый массив двоичных данных) - выбираем последнее добавленное изображение
                showImage(Bar, imUser);  // отображаем картинку
            }
        }
    }
}
