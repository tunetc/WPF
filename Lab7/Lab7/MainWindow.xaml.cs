﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;


namespace Lab7
{
    public partial class MainWindow : Window
    {
        double[] startPosX = new double[4];
        double startPosY;
        public MainWindow()
        {
            InitializeComponent();
            startPosY = Canvas.GetTop(canvas1.Children[0]);
            for (int i = 0; i < 4; i++)
                startPosX[i] = Canvas.GetLeft(canvas1.Children[i]);
            button1.Focus();
        }

        private void canvas1_Drop(object sender, DragEventArgs e)
        {
            if (e.Source is Canvas)
            {
                var trg = e.Source as TextBlock;
                TextBlock src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
                trg.Background = null;
                Point p = e.GetPosition(canvas1);
                Canvas.SetLeft(src, p.X - src.ActualWidth / 2);
                Canvas.SetTop(src, p.Y - src.ActualHeight / 2);
            }
            else
            {
                var trg = e.Source as TextBlock;
                var src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
                if (src == trg) return;
                if ((src.Tag as string)[0] > (trg.Tag as string)[0])
                {
                    Canvas.SetLeft(src, Canvas.GetLeft(trg));
                    Canvas.SetTop(src, Canvas.GetTop(trg));
                    trg.Visibility = Visibility.Hidden;
                }
                else
                    src.Visibility = Visibility.Hidden;
            }
        }

        private void textBlock1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock t = e.Source as TextBlock;
            if (t == null) return;
            t.Foreground = Brushes.Red;
            if (e.ChangedButton == MouseButton.Left)
                if (DragDrop.DoDragDrop(t, t, DragDropEffects.Move) == DragDropEffects.None)
                    t.Visibility = Visibility.Hidden;
            t.Foreground = Brushes.Black;
            string s = "";
            for (int i = 0; i < 4; i++)
            {
                if (canvas1.Children[i].IsVisible) return;
                s += (uniformGrid1.Children[i] as TextBox).Text;
            }
            if (s == "") return;
            mark1.Fill = Brushes.Green;
            captionl.Foreground = Brushes.Green;
            captionl.Text = "Звіринець відкритий";
        }

        private void canvas1_DragEnter(object sender, DragEventArgs e)
        {
            e.Handled = true;
            e.Effects = DragDropEffects.Move;
            var trg = e.Source as TextBlock;
            if (trg == null) return;
            trg.Background = Brushes.Yellow;

        }

        private void canvas1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Source is Canvas) return;
            e.Handled = true;
            e.Effects = e.Data.GetData(typeof(TextBlock)) == e.Source ? DragDropEffects.Move : DragDropEffects.None;

        }

        private void uniformGrid1_PreviewDragEnter(object sender, DragEventArgs e)
        {
            e.Handled = true;
            e.Effects = DragDropEffects.Move;
        }

        private void uniformGrid1_Drop(object sender, DragEventArgs e)
        {
            var trg = e.Source as TextBox;
            if (trg == null) return;
            var src = e.Data.GetData(typeof(TextBlock)) as TextBlock;
            if ((src.Tag as string)[0] >= (trg.Tag as string)[0])
            {
                trg.Text = src.Text;
                trg.Tag = src.Tag;
            }
            src.Visibility = Visibility.Hidden;
        }

        private void canvas1_DragLeave(object sender, DragEventArgs e)
        {
            e.Handled = true;
            var trg = e.Source as TextBlock;
            if (trg == null) return;
            trg.Background = null;
        }

        private void Window_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            if (e.Effects == DragDropEffects.Move)
            {
                e.UseDefaultCursors = false;
                Mouse.SetCursor(Cursors.Hand);
            }
            else
                e.UseDefaultCursors = true;
            e.Handled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                var t = canvas1.Children[i];
                t.Visibility = Visibility.Visible;
                Canvas.SetTop(t, startPosY);
                Canvas.SetLeft(t, startPosX[i]);
                var tb = uniformGrid1.Children[i] as TextBox;
                tb.Text = "";
                tb.Tag = "0";
                mark1.Fill = Brushes.Red;
                captionl.Foreground = Brushes.Red;
                captionl.Text = "Звіринець закритий";
            }
        }
    }
    }