   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangMan.ViewsHangMan.Views  5   	   7 clr-namespace:HangMan.ViewModelsHangMan.ViewModels  5   	   $    HangMan.Views.ChooseGameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HangMan.Views     5   	   0ctx clr-namespace:HangMan.ViewModels     5   	     � Title$  HangMan��5	   	   $	��550��6   $	��700��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � 	Resources 5
         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType �� CornerRadius	 ��Name
 �� Triggers P� Property P� Value��%8  &	        &	 T     7   �� 5   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 7,7,7,7��6!   #��z��68   8��  ._�5      �� $	 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5      
 5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 ��� �63   �� 5       � ��
 �   �63   5      5      5        � DataContext 5!      ,  &HangMan.ViewModels.ChooseGameViewModel  5"   
   .��5$      ��  �� Orientation$ Vertical=�6   $��0,0,0,-1q�6(   .+�5%   
   �� $��0,40,0,0q�6   .+�5&      �� $%��./../Images/GameWindowTitle.png��6   $	��100��6=   $	��500��6J   $y�Visible=�6V   $��Center=�6k   5'      � 5(   
    � ColumnDefinitions 5)      �� 5*      �� 5+      .+�5-      �� $��1��6   $"��../Images/GameWindowRope.png��6$   $	��300��6J   $
��Left=�6W   $
��65,0q�6r   � 5.      $��0��6    � RowDefinitions 5/      �� 50      $	��11* �6$   �� 51      $	��64* �6$   .+�53      �� $��0��6   $��Choose a category!��6%   $��Comic Sans MS)�6B   $��25(�6]   $��Right=�6k   $	��228��6�   $
��0,30q�6�   6�   �� 54      $��1��6   $��Right=�6*   $	��220��6F   $��20,0,0,0q�6R   .+�56      	� $	��150��6"   $��All Categories��6.   $��20(�6G   $��Center=�6U   $
��Left=�6w   $��20,0,0,0q�6�    d� 	IsChecked 6�   �� *AllCategories+	� 57      $	��100��6"   $��Rivers��6.   $��20(�6?   $��Center=�6M   $
��Left=�6o   $��20,0,0,0q�6�    6�   �� *RiversCategory+	� 58      $	��100��6"   $
��Cars��6.   $��20(�6=   $��Center=�6K   $
��Left=�6m   $��20,0,0,0q�6�    6�   �� *CarsCategory+	� 59      $	��100��6"   $��Movies��6.   $��20(�6?   $��Center=�6M   $
��Left=�6o   $��20,0,0,0q�6�    6�   �� *MoviesCategory+	� 5:      $	��100��6"   $��Flower��6.   $��20(�6?   $��Center=�6M   $
��Left=�6o   $��20,0,0,0q�6�    6�   �� *FlowersCategory+5<      5>      5?      �� 5@   
   $ 
Horizontal=�6   .+�5A      �� -   5         ��Name$
 Back��5A      $
��Back��6#   $��44��62   $��Comic Sans MS)�6>   $��25(�6Y   $	��126��6g   $��
20,20,0,20q�6s   #��[ 6�   ��6�   �� *BackCommand+6�   �� 5B      -   5        $
 Play��5B      $
��Play��6#   $��44��62   $��Comic Sans MS)�6>   $��25(�6Y   $	��126��6g   $��390,20,0,20q�6s   #��[ 6�   ��6�   �� *StartGameCommand+6�   5C      5D      5E      