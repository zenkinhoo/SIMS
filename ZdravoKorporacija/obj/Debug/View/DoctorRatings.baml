   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	        Bolnica.View.DoctorRatings   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	   -   5          � WindowStyle$  
ToolWindow=�5	       � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	    � Title$ DoctorRatings��5   	   $	��450��6   $	��550��6,   $��Segoe UI Black)�68   ���	#FFBBB6B6.��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $��3* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��3* �6   �� 5      $��3* �6   �� 5      $��5* �6   �� 5      $
��0.5* �6   .+�5"   
   �� $��1��6   $��1��6    $��3��6-   $5��//ZdravoKorporacija;component/Images/profile.png��6>   6y   �� 5#   
   -   5        $��labelNameRatings��5#   G   $��1��6   $��4��6    $��Lazar's Ratings��6-   $��Center=�6`   $��Center=�6   $��13(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5$   
   -   5        $��labelNameComments��5$   f   $��3��6   $��4��6    $��Lazar's Comments��6-   $��Center=�6I   $��Center=�6�   $��13(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5%   
   -   5        $��	labelName��5%   =   $��2��6   $��1��6    $��Lazar��6-   $��Center=�6O   $��Center=�6n   $��15(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5&   
   -   5        $��labelSurname��5&   @   $��2��6   $��2��6    $��Mitrovic��6-   $��Center=�6U   $��Center=�6t   $��15(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5'   
   -   5        $��labelSpecialty��5'   B   $��2��6   $��3��6    $��
Psihijatar��6-   $��Center=�6Y   $��Center=�6x   $��15(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5(   
   -   5        $��labelNameOverall��5(   R   $��3��6   $��1��6    $ ��Lazar's Overall Rating:5/5��6-   $��Center=�6k   $��Center=�6�   $��15(�6�   $��Center=�6�   $��Segoe UI Black)�6�   $��Center=�6�   �� 5)   
   -   5        $��DoctorRatingsList��5)      $��1��6,   $��2��6<   $��5��6P   ���	#FFDDDDDD$��15(�6t   $��0,0,20,0q�6�   $��3q�6�   ���	#FF4D4B4B6�   �� 5*   
   -	   5        $��DoctorCommentList��5*      $��3��6,   $��5��6<   ���	#FFDDDDDD$��15(�6`   $��0q�6n   $��3q�6y   ���	#FF4D4B4B6�   �� 5+   
   -
   5        $��1��5+      $��6��6!   $��Rate Doctor��6.   $��14(�6D   $��Segoe UI Black)�6R   $��3q�6n   ���	#FF4D4B4B$��
0,10,10,10q�6�   6�   �� 5,   
   -   5        $��2��5,      $��6��6!   $��Close��6.   $��14(�6>   $��Segoe UI Black)�6L   $��3q�6h   ���	#FF4D4B4B$��10,10,20,10q�6�   6�   �� 5-   
   $��3��6   $��2��6    $��2��6-   $7��1/ZdravoKorporacija;component/Images/fivestars.png��6>   6{   5.      5/      