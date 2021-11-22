using Auto_complate_text.Command;
using Auto_complate_text.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Auto_complate_text.View_Models
{
    public class MainViewModel : BaseViewModel
    {
        public MainWindow MainWindows { get; set; }


        private ObservableCollection<Word> _Words { get; set; }

        public ObservableCollection<Word> Words
        {
            get { return _Words; }
            set { _Words = value; OnPropertyChanged(); }
        }

        public Word _word { get; set; }

        public Word word
        {
            get { return _word; }
            set { _word = value; OnPropertyChanged(); }
        }


        public RelayCommand SpaceCommand { get; set; }

        public RelayCommand AddAutoComplateCommand { get; set; }

        public RelayCommand UpperOnCommand { get; set; }

        public RelayCommand Button1Command { get; set; }
        public RelayCommand Button2Command { get; set; }
        public RelayCommand Button3Command { get; set; }
        public RelayCommand Button4Command { get; set; }
        public RelayCommand Button5Command { get; set; }
        public RelayCommand Button6Command { get; set; }
        public RelayCommand Button7Command { get; set; }
        public RelayCommand Button8Command { get; set; }
        public RelayCommand Button9Command { get; set; }

        public RelayCommand ListboxFilterCommand { get; set; }

        public RelayCommand ButtonRightClickCommand { get; set; }

        public RelayCommand ListboxDoubleCLickCommand { get; set; }

        public RelayCommand LoadedCommand { get; set; }

        bool upper = false;

        int A = 0;
        char a = ' ';
        int B = 0;
        char b = ' ';
        int C = 0;
        char c = ' ';
        int N1 = 0;
        char n1 = ' ';


        int D = 0;
        char d = ' ';
        int E = 0;
        char e = ' ';
        int F = 0;
        char f = ' ';
        int N2 = 0;
        char n2 = ' ';



        int G = 0;
        char g = ' ';
        int H = 0;
        char h = ' ';
        int I = 0;
        char i = ' ';
        int N3 = 0;
        char n3 = ' ';


        int J = 0;
        char j = ' ';
        int K = 0;
        char k = ' ';
        int L = 0;
        char l = ' ';
        int N4 = 0;
        char n4 = ' ';


        int M = 0;
        char m = ' ';
        int N = 0;
        char n = ' ';
        int O = 0;
        char o = ' ';
        int N5 = 0;
        char n5 = ' ';


        int P = 0;
        char p = ' ';
        int Q = 0;
        char q = ' ';
        int R = 0;
        char r = ' ';
        int N6 = 0;
        char n6 = ' ';


        int S = 0;
        char s = ' ';
        int T = 0;
        char t = ' ';
        int U = 0;
        char u = ' ';
        int N7 = 0;
        char n7 = ' ';


        int V = 0;
        char v = ' ';
        int W = 0;
        char w = ' ';
        int N8 = 0;
        char n8 = ' ';


        int X = 0;
        char x = ' ';
        int Y = 0;
        char y = ' ';
        int Z = 0;
        char z = ' ';
        int N9 = 0;
        char n9 = ' ';
        int N0 = 0;
        char n0 = ' ';


        int buttoncounter = 0;

        public MainViewModel()
        {
            Thread thread = new Thread(() => { async(); });


            thread.Start();

            SpaceCommand = new RelayCommand((sender) =>
            {

                MainWindows.TextBox1.Text += " ";
            });



            LoadedCommand = new RelayCommand((sender) =>
            {
                if (MainWindows.TextBox1.Text.LastIndexOf(' ') != null)
                {
                    MainWindows.listbox.Visibility = Visibility.Visible;

                    upper = true;
                }
            });

            AddAutoComplateCommand = new RelayCommand((sender) =>
            {


                Words.Add(new Word()
                {
                    Text = MainWindows.TextBox1.SelectedText
                });

            });

            UpperOnCommand = new RelayCommand((sender) =>
            {

                buttoncounter++;

                if (buttoncounter % 1 == 0)
                {
                    MainWindows.UpperButton.Content = "Upper off";

                    MainWindows.Button1.Content = MainWindows.Button1.Content.ToString().ToLower();
                    MainWindows.Button2.Content = MainWindows.Button2.Content.ToString().ToLower();
                    MainWindows.Button3.Content = MainWindows.Button3.Content.ToString().ToLower();
                    MainWindows.Button4.Content = MainWindows.Button4.Content.ToString().ToLower();
                    MainWindows.Button5.Content = MainWindows.Button5.Content.ToString().ToLower();
                    MainWindows.Button6.Content = MainWindows.Button6.Content.ToString().ToLower();
                    MainWindows.Button7.Content = MainWindows.Button7.Content.ToString().ToLower();
                    MainWindows.Button8.Content = MainWindows.Button8.Content.ToString().ToLower();
                    MainWindows.Button9.Content = MainWindows.Button9.Content.ToString().ToLower();

                    upper = false;
                }

                if (buttoncounter % 2 == 0)
                {
                    MainWindows.UpperButton.Content = "Upper on";

                    MainWindows.Button1.Content = MainWindows.Button1.Content.ToString().ToUpper();
                    MainWindows.Button2.Content = MainWindows.Button2.Content.ToString().ToUpper();
                    MainWindows.Button3.Content = MainWindows.Button3.Content.ToString().ToUpper();
                    MainWindows.Button4.Content = MainWindows.Button4.Content.ToString().ToUpper();
                    MainWindows.Button5.Content = MainWindows.Button5.Content.ToString().ToUpper();
                    MainWindows.Button6.Content = MainWindows.Button6.Content.ToString().ToUpper();
                    MainWindows.Button7.Content = MainWindows.Button7.Content.ToString().ToUpper();
                    MainWindows.Button8.Content = MainWindows.Button8.Content.ToString().ToUpper();
                    MainWindows.Button9.Content = MainWindows.Button9.Content.ToString().ToUpper();

                    upper = true;
                }


            });

            ListboxDoubleCLickCommand = new RelayCommand((sender) =>
                {
                    try
                    {


                        var a = MainWindows.listbox.SelectedItem as Word;

                        string lastWord = MainWindows.TextBox1.Text.Split(' ').Last();

                        if (MainWindows.TextBox1.Text.LastIndexOf(' ') != null)
                        {

                            string newStr = MainWindows.TextBox1.Text.Remove(MainWindows.TextBox1.Text.LastIndexOf(' ')).TrimEnd();


                            MainWindows.TextBox1.Text = "";
                            MainWindows.TextBox1.Text += $"{newStr} {a.Text}";

                        }

                    }
                    catch (Exception)
                    {

                        MessageBox.Show("The Auto complate is not activated when the first word is typed. ");

                    }

                });


            ListboxFilterCommand = new RelayCommand((sender) =>
            {

                string lastWord = MainWindows.TextBox1.Text.Split(' ').Last();


                MainWindows.listbox.ItemsSource = null;

                if (string.IsNullOrEmpty(lastWord) == false)
                {
                    MainWindows.listbox.ItemsSource = null;
                    MainWindows.listbox.Items.Clear();

                    foreach (var item in Words)
                    {
                        if (item.Text.StartsWith(lastWord))
                        {
                            MainWindows.listbox.Items.Add(item);
                        }
                        MainWindows.listbox.ItemsSource = null;


                    }
                }

                else
                {
                    MainWindows.listbox.Items.Clear();

                    foreach (var item in Words)
                    {

                        MainWindows.listbox.Items.Add(item);


                    }
                }


            });


            Button1Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {
                    A = MainWindows.Button1.Content.ToString().IndexOf('A');
                    a = MainWindows.Button1.Content.ToString().ElementAt(A);

                    B = MainWindows.Button1.Content.ToString().IndexOf('B');
                    b = MainWindows.Button1.Content.ToString().ElementAt(B);

                    C = MainWindows.Button1.Content.ToString().IndexOf('C');
                    c = MainWindows.Button1.Content.ToString().ElementAt(C);

                    N1 = MainWindows.Button1.Content.ToString().IndexOf('1');
                    n1 = MainWindows.Button1.Content.ToString().ElementAt(N1);

                }

                if (upper == false)
                {
                    A = MainWindows.Button1.Content.ToString().IndexOf('a');
                    a = MainWindows.Button1.Content.ToString().ElementAt(A);

                    B = MainWindows.Button1.Content.ToString().IndexOf('b');
                    b = MainWindows.Button1.Content.ToString().ElementAt(B);

                    C = MainWindows.Button1.Content.ToString().IndexOf('c');
                    c = MainWindows.Button1.Content.ToString().ElementAt(C);

                    N1 = MainWindows.Button1.Content.ToString().IndexOf('1');
                    n1 = MainWindows.Button1.Content.ToString().ElementAt(N1);
                }


                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {

                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = a.ToString();
                    Thread.Sleep(100);
                }


                if (buttoncounter % 2 == 0)
                {

                    MainWindows.Lettertextbock.Text = b.ToString();

                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {
                    MainWindows.Lettertextbock.Text = c.ToString();

                    Thread.Sleep(100);

                }

                if (buttoncounter % 4 == 0)
                {
                    MainWindows.Lettertextbock.Text = n1.ToString();

                    Thread.Sleep(100);

                }



            });

            Button2Command = new RelayCommand((sender) =>
            {

                if (upper == true)
                {
                    D = MainWindows.Button2.Content.ToString().IndexOf('D');
                    d = MainWindows.Button2.Content.ToString().ElementAt(D);

                    E = MainWindows.Button2.Content.ToString().IndexOf('E');
                    e = MainWindows.Button2.Content.ToString().ElementAt(E);

                    F = MainWindows.Button2.Content.ToString().IndexOf('F');
                    f = MainWindows.Button2.Content.ToString().ElementAt(F);

                    N2 = MainWindows.Button2.Content.ToString().IndexOf('2');
                    n2 = MainWindows.Button2.Content.ToString().ElementAt(N2);


                }

                if (upper == false)
                {
                    D = MainWindows.Button2.Content.ToString().IndexOf('d');
                    d = MainWindows.Button2.Content.ToString().ElementAt(D);

                    E = MainWindows.Button2.Content.ToString().IndexOf('e');
                    e = MainWindows.Button2.Content.ToString().ElementAt(E);

                    F = MainWindows.Button2.Content.ToString().IndexOf('f');
                    f = MainWindows.Button2.Content.ToString().ElementAt(F);

                    N2 = MainWindows.Button2.Content.ToString().IndexOf('2');
                    n2 = MainWindows.Button2.Content.ToString().ElementAt(N2);
                }

                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = d.ToString();
                    Thread.Sleep(100);
                }


                if (buttoncounter % 2 == 0)
                {


                    MainWindows.Lettertextbock.Text = e.ToString();

                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.Lettertextbock.Text = f.ToString();

                    Thread.Sleep(100);

                }


                if (buttoncounter % 4 == 0)
                {


                    MainWindows.Lettertextbock.Text = n2.ToString();

                    Thread.Sleep(100);

                }


            });



            Button3Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {
                    G = MainWindows.Button3.Content.ToString().IndexOf('G');
                    g = MainWindows.Button3.Content.ToString().ElementAt(G);

                    H = MainWindows.Button3.Content.ToString().IndexOf('H');
                    h = MainWindows.Button3.Content.ToString().ElementAt(H);

                    I = MainWindows.Button3.Content.ToString().IndexOf('I');
                    i = MainWindows.Button3.Content.ToString().ElementAt(I);

                    N3 = MainWindows.Button3.Content.ToString().IndexOf('3');
                    n3 = MainWindows.Button3.Content.ToString().ElementAt(N3);

                }



                if (upper == false)
                {
                    G = MainWindows.Button3.Content.ToString().IndexOf('g');
                    g = MainWindows.Button3.Content.ToString().ElementAt(G);

                    H = MainWindows.Button3.Content.ToString().IndexOf('h');
                    h = MainWindows.Button3.Content.ToString().ElementAt(H);

                    I = MainWindows.Button3.Content.ToString().IndexOf('l');
                    i = MainWindows.Button3.Content.ToString().ElementAt(I);

                    N3 = MainWindows.Button3.Content.ToString().IndexOf('3');
                    n3 = MainWindows.Button3.Content.ToString().ElementAt(N3);

                }


                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = g.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = h.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = i.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 4 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n3.ToString();
                    Thread.Sleep(100);
                }




            });



            Button4Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {
                    J = MainWindows.Button4.Content.ToString().IndexOf('J');
                    j = MainWindows.Button4.Content.ToString().ElementAt(J);

                    K = MainWindows.Button4.Content.ToString().IndexOf('K');
                    k = MainWindows.Button4.Content.ToString().ElementAt(K);

                    L = MainWindows.Button4.Content.ToString().IndexOf('L');
                    l = MainWindows.Button4.Content.ToString().ElementAt(L);

                    N4 = MainWindows.Button4.Content.ToString().IndexOf('4');
                    n4 = MainWindows.Button4.Content.ToString().ElementAt(N4);

                }


                if (upper == false)
                {
                    J = MainWindows.Button4.Content.ToString().IndexOf('j');
                    j = MainWindows.Button4.Content.ToString().ElementAt(J);

                    K = MainWindows.Button4.Content.ToString().IndexOf('k');
                    k = MainWindows.Button4.Content.ToString().ElementAt(K);

                    L = MainWindows.Button4.Content.ToString().IndexOf('l');
                    l = MainWindows.Button4.Content.ToString().ElementAt(L);

                    N4 = MainWindows.Button4.Content.ToString().IndexOf('4');
                    n4 = MainWindows.Button4.Content.ToString().ElementAt(N4);
                }


                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = j.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = k.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = l.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 4 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n4.ToString();
                    Thread.Sleep(100);
                }



            });



            Button5Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {
                    M = MainWindows.Button5.Content.ToString().IndexOf('M');
                    m = MainWindows.Button5.Content.ToString().ElementAt(M);

                    N = MainWindows.Button5.Content.ToString().IndexOf('N');
                    n = MainWindows.Button5.Content.ToString().ElementAt(N);

                    O = MainWindows.Button5.Content.ToString().IndexOf('O');
                    o = MainWindows.Button5.Content.ToString().ElementAt(O);

                    N5 = MainWindows.Button5.Content.ToString().IndexOf('5');
                    n5 = MainWindows.Button5.Content.ToString().ElementAt(N5);

                }

                if (upper == false)
                {
                    M = MainWindows.Button5.Content.ToString().IndexOf('m');
                    m = MainWindows.Button5.Content.ToString().ElementAt(M);

                    N = MainWindows.Button5.Content.ToString().IndexOf('n');
                    n = MainWindows.Button5.Content.ToString().ElementAt(N);

                    O = MainWindows.Button5.Content.ToString().IndexOf('o');
                    o = MainWindows.Button5.Content.ToString().ElementAt(O);

                    N5 = MainWindows.Button5.Content.ToString().IndexOf('5');
                    n5 = MainWindows.Button5.Content.ToString().ElementAt(N5);
                }

                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = m.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = o.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 4 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n5.ToString();
                    Thread.Sleep(100);
                }




            });




            Button6Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {
                    P = MainWindows.Button6.Content.ToString().IndexOf('P');
                    p = MainWindows.Button6.Content.ToString().ElementAt(P);

                    Q = MainWindows.Button6.Content.ToString().IndexOf('Q');
                    q = MainWindows.Button6.Content.ToString().ElementAt(Q);

                    R = MainWindows.Button6.Content.ToString().IndexOf('R');
                    r = MainWindows.Button6.Content.ToString().ElementAt(R);

                    N6 = MainWindows.Button6.Content.ToString().IndexOf('6');
                    n6 = MainWindows.Button6.Content.ToString().ElementAt(N6);

                }


                if (upper == false)
                {
                    P = MainWindows.Button6.Content.ToString().IndexOf('p');
                    p = MainWindows.Button6.Content.ToString().ElementAt(P);

                    Q = MainWindows.Button6.Content.ToString().IndexOf('q');
                    q = MainWindows.Button6.Content.ToString().ElementAt(Q);

                    R = MainWindows.Button6.Content.ToString().IndexOf('r');
                    r = MainWindows.Button6.Content.ToString().ElementAt(R);

                    N6 = MainWindows.Button6.Content.ToString().IndexOf('6');
                    n6 = MainWindows.Button6.Content.ToString().ElementAt(N6);
                }

                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = p.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = q.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = r.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 4 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n6.ToString();
                    Thread.Sleep(100);
                }




            });




            Button7Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {
                    S = MainWindows.Button7.Content.ToString().IndexOf('S');
                    s = MainWindows.Button7.Content.ToString().ElementAt(S);

                    T = MainWindows.Button7.Content.ToString().IndexOf('T');
                    t = MainWindows.Button7.Content.ToString().ElementAt(T);

                    U = MainWindows.Button7.Content.ToString().IndexOf('U');
                    u = MainWindows.Button7.Content.ToString().ElementAt(U);

                    N7 = MainWindows.Button7.Content.ToString().IndexOf('7');
                    n7 = MainWindows.Button7.Content.ToString().ElementAt(N7);

                }

                if (upper == false)
                {
                    S = MainWindows.Button7.Content.ToString().IndexOf('s');
                    s = MainWindows.Button7.Content.ToString().ElementAt(S);

                    T = MainWindows.Button7.Content.ToString().IndexOf('t');
                    t = MainWindows.Button7.Content.ToString().ElementAt(T);

                    U = MainWindows.Button7.Content.ToString().IndexOf('u');
                    u = MainWindows.Button7.Content.ToString().ElementAt(U);

                    N7 = MainWindows.Button7.Content.ToString().IndexOf('7');
                    n7 = MainWindows.Button7.Content.ToString().ElementAt(N7);
                }

                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = s.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = t.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = u.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 4 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n7.ToString();
                    Thread.Sleep(100);
                }




            });



            Button8Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {

                    V = MainWindows.Button8.Content.ToString().IndexOf('V');
                    v = MainWindows.Button8.Content.ToString().ElementAt(V);

                    W = MainWindows.Button8.Content.ToString().IndexOf('W');
                    w = MainWindows.Button8.Content.ToString().ElementAt(W);



                    N8 = MainWindows.Button8.Content.ToString().IndexOf('8');
                    n8 = MainWindows.Button8.Content.ToString().ElementAt(N8);

                }

                if (upper == false)
                {

                    V = MainWindows.Button8.Content.ToString().IndexOf('v');
                    v = MainWindows.Button8.Content.ToString().ElementAt(V);

                    W = MainWindows.Button8.Content.ToString().IndexOf('w');
                    w = MainWindows.Button8.Content.ToString().ElementAt(W);



                    N8 = MainWindows.Button8.Content.ToString().IndexOf('8');
                    n8 = MainWindows.Button8.Content.ToString().ElementAt(N8);
                }

                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = v.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = w.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n8.ToString();
                    Thread.Sleep(100);
                }


            });



            Button9Command = new RelayCommand((sender) =>
            {
                if (upper == true)
                {

                    X = MainWindows.Button9.Content.ToString().IndexOf('X');
                    x = MainWindows.Button9.Content.ToString().ElementAt(X);

                    Y = MainWindows.Button9.Content.ToString().IndexOf('Y');
                    y = MainWindows.Button9.Content.ToString().ElementAt(Y);


                    Z = MainWindows.Button9.Content.ToString().IndexOf('Z');
                    z = MainWindows.Button9.Content.ToString().ElementAt(Z);


                    N9 = MainWindows.Button9.Content.ToString().IndexOf('9');
                    n9 = MainWindows.Button9.Content.ToString().ElementAt(N9);



                    N0 = MainWindows.Button9.Content.ToString().IndexOf('0');
                    n0 = MainWindows.Button9.Content.ToString().ElementAt(N0);

                }


                if (upper == false)
                {
                    X = MainWindows.Button9.Content.ToString().IndexOf('x');
                    x = MainWindows.Button9.Content.ToString().ElementAt(X);

                    Y = MainWindows.Button9.Content.ToString().IndexOf('y');
                    y = MainWindows.Button9.Content.ToString().ElementAt(Y);


                    Z = MainWindows.Button9.Content.ToString().IndexOf('z');
                    z = MainWindows.Button9.Content.ToString().ElementAt(Z);


                    N9 = MainWindows.Button9.Content.ToString().IndexOf('9');
                    n9 = MainWindows.Button9.Content.ToString().ElementAt(N9);



                    N0 = MainWindows.Button9.Content.ToString().IndexOf('0');
                    n0 = MainWindows.Button9.Content.ToString().ElementAt(N0);
                }


                buttoncounter++;




                if (buttoncounter % 1 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = x.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 2 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = y.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 3 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = z.ToString();
                    Thread.Sleep(100);
                }

                if (buttoncounter % 4 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n9.ToString();
                    Thread.Sleep(100);
                }


                if (buttoncounter % 5 == 0)
                {


                    MainWindows.TextBox1.SelectAll();

                    MainWindows.Lettertextbock.Text = n0.ToString();
                    Thread.Sleep(100);
                }

            });


            ButtonRightClickCommand = new RelayCommand((sender) =>
            {
                if (MainWindows.Lettertextbock.Text != "Auto compilation with T9 keyboard")
                {
                    MainWindows.TextBox1.Text += MainWindows.Lettertextbock.Text;
                }
            });




        }

        void async()
        {
            Task.Run(() =>
            {
                var t1 = new Task(() => { words(); });

                Task.Delay(5000);
             

                t1.Start();

                Task.Delay(5000);

            });
        }

        void words()
        {



            Words = new ObservableCollection<Word>();

            Words.Add(new Word()
            {
                Text = "Azerbaijan"
            });

            Words.Add(new Word()
            {
                Text = "Baku"
            });

            Words.Add(new Word()
            {
                Text = "apple"
            });

            Words.Add(new Word()
            {
                Text = "pear"
            });

            Words.Add(new Word()
            {
                Text = "doomsday"
            });

            Words.Add(new Word()
            {
                Text = "Cristian"
            });

            Words.Add(new Word()
            {
                Text = "Muslim"
            });

            Words.Add(new Word()
            {
                Text = "Shamanism"
            });

            Words.Add(new Word()
            {
                Text = "Tengriism"
            });

            Words.Add(new Word()
            {
                Text = "antichrist"
            });

            Words.Add(new Word()
            {
                Text = "Dhu'l-Qarnayn"
            });

            Words.Add(new Word()
            {
                Text = "Devil"
            });

            Words.Add(new Word()
            {
                Text = "Angel"
            });

            Words.Add(new Word()
            {
                Text = "fake"
            });

            Words.Add(new Word()
            {
                Text = "snake"
            });

            Words.Add(new Word()
            {
                Text = "djinn"
            });

            Words.Add(new Word()
            {
                Text = "fairy"
            });

            Words.Add(new Word()
            {
                Text = "human"
            });

            Words.Add(new Word()
            {
                Text = "eco"
            });

            Words.Add(new Word()
            {
                Text = "ego"
            });
        }


    }
}
