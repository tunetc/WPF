   M S B A M L   `   `   `  ����?  ;Lab7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab7Lab7  5   	       Lab7.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab7     5   	   -   5          � Title$  Звіринець��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�6:    � 
ResizeMode$ CanMinimize=�5	   	   .��5
      �� .+�5   
   �� -   5         ��Name$ canvas1��5      $��10q�6"   $	��480��6.   $	��240��6:   
������� J� 	AllowDrop$
 True��6^   .+�5      �� -   5         ��Name$ 
textBlock1��5       �� Left$ 30��6,   $��Леопард��6=   
 �� Top$ 41��6L   	 �� Padding$	 5q�6\   

 � Tag$
 4��6h   �� 5      -   5        $ 
textBlock2��5      $	 130��6,   $��
Кабан��6>   $ 41��6K   $	 5q�6[   $
 3��6g   �� 5      -   5        $ 
textBlock3��5      $	 230��6,   $��Тигр��6>   $ 41��6J   $	 5q�6Z   $
 2��6f   �� 5      -   5        $ 
textBlock4��5      $	 330��6,   $��Бурундук��6>   $ 41��6N   $	 5q�6^   $
 1��6j   5      A� 5   
   -   5         A�Name$ uniformGrid1��5      $��10, 0, 10, 0q�6,    A� Columns$ 4��6B   $
 True��6N   .+�5      �� $�� ��6    �� 
IsReadOnly$
 True��6   
�������$
 0��6B   �� 5      $�� ��6   $
 True��6   
�������$
 0��6B   �� 5      $�� ��6   $
 True��6   
�������$
 0��6B   �� 5      $�� ��6   $
 True��6   
�������$
 0��6B   5      �� 5   
   -   5         ��Name$ button1��5      $��Center=�6"   $��0,0,0,10q�6?   .��5      �� $	��5,0q�6    �� Orientation$ 
Horizontal=�6&   .+�5      A� -	   5         A�Name$ mark1��5      $��5q�6)   
���  ��$��15��6?   $��15��6J   �� 5      -
   5        $ captionl��5      $��5q�6.   
���  ��$)��#Звіринець закритий��6J   5      5       5!      5"      