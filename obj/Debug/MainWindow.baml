   M S B A M L   `   `   `  ����I  Equanlichannuoi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:quanlichannuoiquanlichannuoi  5   	       quanlichannuoi.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:quanlichannuoi     5   	     � Title$  Đăng nhập��5   	   $	��450��6   $	��800��6(   .��5	      � ��5
   
   �� 5       �� ImageSource$D >C:\Users\Computer\Documents\OneDrive\Pictures\anh-dong-que.jpg��6    j� Stretch$
 Fill=�6f    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��3* �6   �� 5      $��* �6   .+�5   
   �� $��Quản lí chăn nuôi��6   $��0��5      $��1��6   $��20(�5      $��Arial Black)�6   $��Center=�5      $��Center=�6#   �� 5   
   -   5        $��
LoginPanel��5      $��1��6(   $��1��65   $��Center=�6E   $��Center=�6`   $	��400��6}   $	��308��6�   .+�5      �� $��1��6   $��
Xin Chào,��6$   $
��Left=�68   $��1��6T   $	��Top=�6a   $	��104��6y   $
��Bold"�6�   $��44��6�   $��20(�6�   �� 5      $��1��6   $<��6Vui lòng đăng nhập để sử dụng hệ thống��6$   $
��Left=�6U   $��1��6q   $	��Top=�6~   $	��266��6�   $��14(�6�   �� 5      $��Username��6   $��16(�6'   $
��Left=�65   $
��Bold"�6P   �� 5      -   5        $��username_txt��5      $	��400��6*   $��40��66   �� 5       $��Password��6   $��16(�6'   $
��Left=�65   $��0,10,0,0q�6P   $
��Bold"�6b   �� 5!      -   5        $��password_txt��5!      $	��400��6*   $��40��66   �� 5"       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0,20,0,0q�6O   .+�5#      �� -   5        $��	login_btn��5#   )   $��Login��6   $	��100��6:   $��40��6F   $
��10,0q�6R   6`   �� 5$      -   5        $��
signup_btn��5$   *   $��Signup��6   $	��100��6<   $��40��6H   $
��10,0q�6T   6b   �� 5%      -   5        $��
Logout_btn��5%   *   $��Logout��6   $	��100��6<   $��40��6H   $
��10,0q�6T   6b   5&      5'       � 5(   
   -   5        $��
Windowpage��5(      $��0��6"   $��0��6/   $��3��6?   $��3��6P   6d   5*      5+      