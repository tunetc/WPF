   M S B A M L   `   `   `  ����?  ;Lab2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab2Lab2  5   	       Lab2.Window2   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab2     5   	   -   5          � Title$#  Діалогове вікно��5   	   $	��200��6!   $	��450��6.    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.    � ShowInTaskbar$ False��6D    � WindowStyle$ 
ToolWindow=�5
   	    � SizeToContent$ WidthAndHeight=�6;   .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $7��1Заголовок головного вікна:��6   $��5q�65   �� 5   
   $E��?Заголовок підпорядкованого вікна:��6   $��5q�6<   $��1��6G   �� 5   
   -   5         ��Name$ textBox1��5      $��1��6$   $��5q�64   $��Головне вікно��6?   $	��200��5      �� 5   
   -   5        $ textBox2��5      $��1��6$   $��5q�64   $��1��6?   $-��'Підпорядковане вікно��5      $	��200��6.   �� 5   
   $��2��6   $��Right=�6)   $��0q�6E   $��2��6P   	 �� Orientation$	 
Horizontal=�5      .+�5      �� -   5        
 ��Name$
 button21��5      $��OK��6'   $��75��64   $��5q�6?    �� 	IsDefault$
 True��6J   5      �� 5       -   5        $
 button22��5       $��Застосувати��6'   $��75��6=   $��5q�6H   5!      �� 5"      $��Відміна��6   $��75��6'   $��5q�62    �� IsCancel$
 True��6=   5#      5$      5%      