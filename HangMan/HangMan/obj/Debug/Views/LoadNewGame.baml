   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangMan.ViewsHangMan.Views  5   	   7 clr-namespace:HangMan.ViewModelsHangMan.ViewModels  5   	       HangMan.Views.LoadNewGame   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HangMan.Views     5   	   0ctx clr-namespace:HangMan.ViewModels     5   	     � Title$  HangMan��5	   	   $	��550��6   $	��700��6&    � 
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
 �   �63   5      5      5        � DataContext 5!      -   'HangMan.ViewModels.LoadNewGameViewModel  5"   
   .��5$      ��  �� Orientation$ Vertical=�6   .+�5%   
   �� $��0,40,0,0q�6   .+�5&      �� $%��./../Images/GameWindowTitle.png��6   $	��100��6=   $	��500��6J   $y�Visible=�6V   $��Center=�6k   5'      � 5(   
    � ColumnDefinitions 5)      �� 5*      �� 5+      .+�5-      �� $��1��6   $"��../Images/GameWindowRope.png��6$   $	��300��6J   $
��Left=�6W   $
��65,0q�6r   � 5.      $��0��6    � RowDefinitions 5/      �� 50      $	��11* �6$   �� 51      $	��64* �6$   .+�53      �� $��1��6   $��Right=�6*   $	��220��6F   $��20,0,0,0q�6R   .+�54      �� -   5         ��Name$ NewGame��54      $��30(�6.   $	��200��6<   $��45��6H   $��
0,50, 0, 0q�6T   $��New Game��6h   $��Comic Sans MS)�6{   #��[ 6�   ��6�   �� *NewGameCommand+6�   �� 55      -   5        $ LoadGame��55      $��30(�6/   $	��200��6=   $��45��6I   $��0,30,0,0q�6U   $��	Load Game��6g   $��Comic Sans MS)�6{   #��[ 6�   ��6�   �� *LoadGameCommand+6�   56      57      58      �� 59   
   $ 
Horizontal=�6   .+�5:      �� -   5        $
 Back��5:      $
��Back��6#   $��39��62   $��Comic Sans MS)�6>   $��25(�6Y   $	��100��6g   $��
20,20,0,20q�6s   #��[ 6�   ��6�   �� *BackCommand+6�   5;      5<      5=      