   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	       Bolnica.View.Tutorial   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStyle$  
ToolWindow=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ Tutorial��5
   	   $	��720��6   $
��1280��6'   $��Segoe UI Black)�64   ���	#FFBBB6B6.��5      �  � RowDefinitions 5   
   �� 5      $	��22* �6   �� 5      $	��79* �6   �� 5      $
��434* �6   �� 5      $	��20* �6   �� 5      $	��70* �6   �� 5      $	��90* �6   �� 5      $	��22* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $	��20* �6   �� 5      $	��25* �6   �� 5      $	��20* �6   �� 5      $��3* �6   .+�5   
   �� $��2��6   $��1��6    $��How to use application��6-   $��Center=�6O   $��Center=�6m   $��35(�6�   $��57��6�   $
��6,11q�6�   $	��408��6�   r� 5   
   -   5        $��myMedia��5   H   $��1��6   $��2��6'   $��3��64    r� Source$6 0C:\Users\Lenovo T450\Desktop\hci_final_video.wmv?�6Y    r� LoadedBehavior$ Manual=�5      �� 5   
   -   5        $��2��5      $��4��6#   $
��Left=�6E   $
��Left=�6`   $��	120,0,0,0q�6�   ��5       �� 5!      .R�5"      �� $2��,/ZdravoKorporacija;component/Images/play.gif��6   5#       � ToolTip 5%      �� 5&      .+�5'      �� $
��Bold"�6    $��14(�62   $��0,0,0,5q�6@   Click the button6c   �� 5(      Click here to play video5*      �� 5+      
�������$��0,1,0,0q�62   $	��0,8q�6L   � 5,      .+�5-      �� $��/Images/bell.png��6    $��0,0,0,0q�6:   $��15��6K   $��20��6W   �� 5.      $��Italic$�6$   Playing video tutorial6O   5/      50      52      �� 53   
   -   5        $��2��53      $��4��6"   $��Right=�6E   $��Right=�6h   $��	0,0,120,0q�6�   ��54      �� 55      .R�56      �� $3��-/ZdravoKorporacija;component/Images/pause.png��6   57       59      �� 5:      .+�5;      �� $
��Bold"�6    $��14(�62   $��0,0,0,5q�6@   Click the button6c   �� 5<      Click here to pause video5>      �� 5?      
�������$��0,1,0,0q�62   $	��0,8q�6L   � 5@      .+�5A      �� $��/Images/bell.png��6    $��0,0,0,0q�6:   $��15��6K   $��20��6W   �� 5B      $��Italic$�6$   Pausing video tutorial6O   5C      5D      5F      �� 5G   
   -   5        $��2��5G      $��5��6"   $
��Skip��60   $��18(�6?   $��Segoe UI Black)�6M   $��3q�6i   ���	#FF4D4B4B$��12q�6�   6�   5H      5I      