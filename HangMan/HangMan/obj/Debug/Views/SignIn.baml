   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangMan.ViewsHangMan.Views  5   	   7 clr-namespace:HangMan.ViewModelsHangMan.ViewModels  5   	       HangMan.Views.SignIn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HangMan.Views     5   	   0ctx clr-namespace:HangMan.ViewModels     5   	     � Title$  HangMan��5	   	   $	��550��6   $	��700��6&    � 
ResizeMode$ NoResize=�62    � WindowStartupLocation$ CenterScreen=�6H    � DataContext 5      (   "HangMan.ViewModels.SignInViewModel  5   
   -   5        signInVM��5       � 	Resources 5         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType	 �� CornerRadius
 ��Name �� Triggers P� Property P� Value��%�  &	        &	 T     7   �� 5   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $	 7,7,7,7��6!   #��z��68   8��  ._�5      �� $
 contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5       5      P� 5       �@J�IsMouseOver . . �5      ��  � ��
 ��� �63   �� 5        � ��
 �   �63   5!      P� 5"       � {� .  . �5#      ��  � ��
 �����63   �� 5$       � ��
 �   �63   5%      5'      5(      .��5)      �� 
�������.+�5*   
   �� $��Sign In��6   
�������
���   �$��45(�5+      $��Center=�6   $	��Top=�6;   $��Comic Sans MS)�5,      $��78��6+   $��204,0q�67   �� 5-   
    �� Orientation$ 
Horizontal=�6   .+�5.      �� -   5        $��UserListLbl��5.      $��	User List��6'   
���   �$��30(�6N   $
��Left=�5/      $��Comic Sans MS)�63   $��100,0q�6N   �� 50      -   5        $��UserPicture��50      $��User Picture��6'   
���   �$��30(�6Q   $��Right=�51      $��Comic Sans MS)�64   $��100,0q�6O   52      �� 53   
   $ 
Horizontal=�6   $
��0,10q�6.   .+�54      �� -   5         ��Name$ UserList��54      $
��Left=�6(   $��Center=�6C   
������ $	��250��55   3   $	��308��6?   $
��40,0q�6L   $��Center=�6|    �� SelectionMode$ Single=�6�   ��6Z   �� *	UsersList+ �� SelectedItem 6�   �� *SelectedUser+��56      �� 57      .R�58      �� $��txtName��6$   $��Comic Sans MS)�6I   $��15(�6d   ��63   �� *Name+6d   59      5;      �� 5<      -   5         ��Name$ 	UserImage��5<   ?   $	��150��6R   $��Right=�6_   $	��150��5=      $��130,0,25,75q�6$   ��5<      �� *SelectedUser.ImagePath+5=   $   5>      �� 5?   
   $ 
Horizontal=�6   .+�5@      �� $ 
Horizontal=�6   $	��320��62   $
��Left=�6>   $
��0,10q�6Y   .+�5A      �� -   5         ��Name$ 
NewUserBtn��5A      $��New User��6-   $��Comic Sans MS)�6@   $��25(�6[   $
��Left=�5B      $	��150��64   $
��10,0q�6@   #��[ 6N   5C      �� 5D      -   5        $ DeleteUserBtn��5D      $��Delete User��60   $��Comic Sans MS)�6F   $��24(�6a   $
��Left=�5E      $	��150��64   #��[ 6@   ��6l   �� *DeleteCommand+5F      �� 5G      $ 
Horizontal=�6   $	��210��62   $��Right=�6>   $��120,10q�6Z   .+�5H      �� -   5        $ PlayBtn��5H      $
��Play��6*   $��Comic Sans MS)�69   $��25(�6T   $��Right=�5I      $	��100��65   #��[ 6A   ��5J      �� *PlayCommand+�� 5K      -	   5        $ BackBtn��5K      $
��Back��6*   $��Comic Sans MS)�69   $��24(�6T   $��Right=�5L      $	��100��65   $
��10,0q�6A   #��[ 6O   5M      5N      5O      5P      5Q      