   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangMan.ViewsHangMan.Views  5   	       HangMan.Views.StartWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HangMan.Views     5   	   -   5          �Name$  startWindow��5   2    � Title$ HangMan��6	   $	��500��6   $	��700��6&    � WindowStartupLocation$ CenterScreen=�6G    � SizeToContent$ Height=�6l    � 
ResizeMode$ NoResize=�6�    � 	Resources 5	         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle	 �� 
TargetType
 �� CornerRadius ��Name �� Triggers P� Property P� Value��%8  &	        &	 T     7   �� 5
   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      "	 ��6&   .R�5      �� $
 7,7,7,7��6!   #��z��68   8��  ._�5      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 ��� �63   �� 5       � ��
 �   �63   5      5      5      .��5       �� .+�5!   
   �� -   5        $��Title��5!      $��
WELCOME TO��6   $��Center=�62   $��Center=�5"      $��40(�6-   $��Comic Sans MS)�6;   $
��Bold"�6V   6j   �� 5#   
   $��./../Images/HangMan.jpg��6   $��Center=�61   $��Center=�6N   $	��300��6i   $	��500��6v   5$      �� 5%   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��Bottom=�6K   $	��210��6f   $��40��6r   $��30q�5&      .+�5'      �� -   5         ��Name$ Start��5'      $
��Left=�6$   $��START��6?   $��25(�6O   $��40��6]   $	��100��6i   $��Comic Sans MS)�5(      $
��Bold"�60   #��[ 6B   5)   *   �� 5*      -   5        $ Close��5*       �� IsCancel . $��Right=�64   $��CLOSE��6P   $��25(�6`   $��40��6n   $	��100��6z   $��Comic Sans MS)�6�   $
��Bold"�5+      #��[ 6'   $
��10,0q�6S   6v   5,      5-      5.      