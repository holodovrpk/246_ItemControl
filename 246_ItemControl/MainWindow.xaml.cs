using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _246_ItemControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Book> books = new ObservableCollection<Book>();
        Book selectBook = new Book();

        public MainWindow()
        {
            InitializeComponent();

            books.Add(new Book { Title = "Книга 1", Author = "Автор 1", Year = 2000, Count = 10, Price = 555, Cover = @"/Images/kirp.jpg"});
            books.Add(new Book { Title = "Книга 2", Author = "Автор 3", Year = 2005, Count = 125, Price = 55, Cover = @"/Images/kirp_gray.jpg"});
            books.Add(new Book { Title = "Книга 3", Author = "Автор 1", Year = 5000, Count = 2, Price = 111, Cover = @"/Images/plitka.jpg"});
            books.Add(new Book { Title = "Книга 5", Author = "Автор 2", Year = 2000, Count = 10, Price = 444, Cover = @"/Images/vedro.jpg"});
            books.Add(new Book { Title = "Книга 4", Author = "Автор 1", Year = 4222, Count = 3, Price = 655, Cover = @"/Images/kirp.jpg"});

            BookPanel.ItemsSource = books;
        }

        private void StackPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            StackPanel s = new StackPanel();
            s = (StackPanel)sender;
            s.Background = Brushes.Blue;
        }

        private void StackPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            StackPanel s = new StackPanel();
            s = (StackPanel)sender;
            s.Background = Brushes.Beige;
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if ((sender as StackPanel).DataContext is Book book)
            {
                txtAuthor.Text = book.Author;
                txtCount.Text = book.Count.ToString();
                txtPrice.Text = book.Price.ToString();
                txtYear.Text = book.Year.ToString();
                txtName.Text = book.Title.ToString();

                selectBook = book;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            books.Add(new Book { Title = "Книга 4", Author = "Автор 1", Year = 4222, Count = 3, Price = 655, Cover = @"/Images/kirp.jpg" });

        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (selectBook != null)
                books.Remove(selectBook);
        }

        private void Delll_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).DataContext is Book book)
            {
                books.Remove(book);
            }
        }
    }
}