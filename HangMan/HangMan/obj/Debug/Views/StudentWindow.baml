   M S B A M L   `   `   `  ����B  >HangMan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HangMan.ViewsHangMan.Views  5   	   !    HangMan.Views.StudentWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HangMan.Views     5   	     � Title$  HangMan��5   	   $	��450��6   $	��800��6&    � WindowStartupLocation$ CenterScreen=�62    � 	Resources 5	         RoundedBorder �� 
TargetType �� Property �� Value  RoundedButtonStyle �� 
TargetType �� CornerRadius ��Name	 �� Triggers
 P� Property P� Value��%8  &	        &	 T     7   �� 5
   
   " ��6&   .�5      ��  �@��CornerRadius$ 5��6-   5      �� 5   
   " ��6+   .�5      ��  � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ 7,7,7,7��6!   #��z��68   8��  ._�5      �� $ contentPresenter��6/   #��z��6I   #��z��6}   #��z��6�   #��z��6�   #��z��6	  5      5      5      	 5      P� 5      
 �@J�IsMouseOver . . �5      ��  � ��
 ��� �63   �� 5       � ��
 �   �63   5      5      5      .��5       �  � RowDefinitions 5!   
   �� 5"      �� 5#      �� 5$      �� 5%      �� 5&      .+�5(   
   �� $��0��6   $��40(�6   $��Comic Sans MS)�6+   $��Black"�6F   $��Center=�6Y   $��Center=�6v   $��Informatii despre student��6�   6�   �� 5)   
   $��1��6   $��30(�6   $��Comic Sans MS)�6+   $��Center=�6F   $��Center=�6c   $��Nume: Burtan Gabriela��6~   �� 5*   
   $��2��6   $��30(�6   $��Comic Sans MS)�6+   $��Center=�6F   $��Center=�6c   $��Grupa: 10LF381��6~   �� 5+   
   $��3��6   $��30(�6   $��Comic Sans MS)�6+   $��Center=�6F   $��Center=�6c   $)��#Specializarea: Informatica aplicata��6~   �� 5,   
   -   5        $��4��5,      $	��200��6   $��50��6*   $��25(�66   $��Comic Sans MS)�6D   $��Center=�6_   $��Center=�6|   $��Cancel��6�   #��[ 6�   5-      5.      