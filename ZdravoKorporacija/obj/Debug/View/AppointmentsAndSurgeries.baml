   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	   +    %Bolnica.View.AppointmentsAndSurgeries   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5   	    � Title$  Appointments And Surgeries��5   	   $	��600��6,   $	��800��69   $��Segoe UI Black)�6E   ���	#FFBBB6B6.��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��50* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $	��20* �6    � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $	��20* �6   �� 5      $	��20* �6   �� 5      $	��25* �6   �� 5      $��8* �6   .+�5   
   �� $��1��6   $ ��Appointments and Surgeries��6!   $��Center=�6G   $��Center=�6e   $��28(�6�   $��Center=�6�   $��2��6�   $��1��6�   $��60��6�   �� 5    
   -   5        $��AppointmentsList��5    /   $��2��6   $��1��6   $��2��6G   $��5��6[   ���	#FFDDDDDD$��15(�6�   $��5q�6�   ���	#FF4D4B4B$��	0,0,2.5,0q�6�   �� 5!   
   -   5        $��2��5!      $��3��6   $��Schedule new appointment��6/   $��17(�6R   $��5q�6a   ���	#FF4D4B4B$��	0,0,0,2.5q�6�   �� 5"   
   -   5        $��3��5"      $��3��6   $��Cancel Appointment��6.   $��22(�6K   $��5q�6Z   ���	#FF4D4B4B$��	0,0,0,2.5q�6�   �� 5#   
   -   5        $��6��5#      $��3��6   $��Close��6.   $��22(�6>   $��5q�6M   ���	#FF4D4B4B$��	0,2.5,0,0q�6�   �� 5$   
   -   5        $��4��5$      $��3��6   $��Update appointment��6.   $��22(�6K   $��5q�6Z   ���	#FF4D4B4B$��	0,0,0,2.5q�6�   �� 5%   
   -   5        $��5��5%      $��3��6   $��Print Report��6/   $��22(�6F   $��5q�6U   ���	#FF4D4B4B J� RenderTransformOrigin$ 0.508,0.571&�6�    � ToolTip 5(      �� 5)      .+�5*      �� $
��Bold"�6    $��14(�62   $��0,0,0,5q�6@   Click the button6c   �� 5+      Click generate pdf report5-      �� 5.      
�������$��0,1,0,0q�62   $	��0,8q�6L   � 5/      .+�50      �� $��/Images/bell.png��6    $��0,0,0,0q�6:   $��15��6K   $��20��6W   �� 51      $��Italic$�6$   !Generating report in PDF format6X   52      53      55      �� 56   
   $��5��6   $��4��6   $1��+/ZdravoKorporacija;component/Images/pdf.png��6-   $��10q�6b   6q   �� 57   
   $��3��6   $��4��6   $4��./ZdravoKorporacija;component/Images/cancel.png��6.   $��10q�6f    J� OpacityMask 58      �� 59       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5:      � 	 � Color$	 Black��6#   
 � Offset$
 0Q�61   � 5;      $	 White��6#   $
 1Q�61   5<      5>      �� 5?   
   $��6��6   $��4��6   $3��-/ZdravoKorporacija;component/Images/close.png��6-   $��10q�6d   6s   �� 5@   
   $��2��6   $��4��6   $6��0/ZdravoKorporacija;component/Images/schedule.png��6-   $��10q�6g   6v   �� 5A   
   $��4��6   $��4��6   $4��./ZdravoKorporacija;component/Images/update.png��6-   $��10q�6e   6t   5C      5D      