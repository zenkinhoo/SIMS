   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   !    Bolnica.View.MedicalHistory   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	   -   5          � WindowStyle$  
ToolWindow=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   $��Segoe UI Black)�5   	   ���	#FFBBB6B6 � Title$ Appointments History��5   	   $	��450��6&   $	��500��63   .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $
��0.5* �6   �� 5      $��2* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��7* �6   �� 5      $��7* �6   �� 5      $��7* �6   �� 5      $
��0.5* �6   .+�5    
   �� $��0��6   $��1��6   $��3��6-   $��Past Appointments��6A   $��Center=�6]   $��Center=�6z   $��Center=�6�   $��Center=�6�   $��19(�6�   $��0,0,10,0q�6�   6�   �� 5!   
   -   5         ��Name$ PastAppointmentsList��5!   9   $��1��6W   $��1��6d   $��15(�6u   $��Center=�6�   ���	#FFDDDDDD$��Segoe UI Black)�6�   $��Center=�6�   $��	79,0,78,0q�6�   $��3��6  $��4q�6%  ���	#FF4D4B4B��6   �� *MedicalHistory+6�  �� 5"   
   -   5        $��1��5"      $��3��6!   $��Close��6/   $��15(�6?   $��Segoe UI Black)�6M   $��3q�6i   ���	#FF4D4B4B$��	10,0,10,0q�6�   6�   �� 5#   
   -   5        $��2��5#      $��3��6!   $��Rate Hospital��6/   $��15(�6G   $��Segoe UI Black)�6U   $��3q�6q   ���	#FF4D4B4B$��	10,0,10,0q�6�   6�   �� 5$   
   -   5        $��3��5$      $��3��6"   $��Doctor's Ratings��60   $��15(�6K   $��Segoe UI Black)�6Y   $��3q�6u   ���	#FF4D4B4B$��	10,0,10,0q�6�    � ToolTip 5%      �� 5&      .+�5'      �� $
��Bold"�6    $��14(�62   $��0,0,0,5q�6@   Click the button6c   �� 5(      /-Click here to see ratings for selected doctor5*      �� 5+      
�������$��0,1,0,0q�62   $	��0,8q�6L   � 5,      .+�5-      �� $��/Images/bell.png��6    $��0,0,0,0q�6:   $��15��6K   $��20��6W   �� 5.      $��Italic$�6$   Showing doctor's ratings6Q   5/      50      52      53      54      