   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Bolnica.ViewsSecretaryBolnica.ViewsSecretary  5      ,    &Bolnica.ViewsSecretary.AddAnnouncement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Bolnica.ViewsSecretary     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5        N� Title$  AddAnnouncement��5
      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��30px �6   6,   �� 5      $
��30px �6   6,   �� 5      $��55 �6   6*   �� 5      $��45 �6   6*   �� 5      6   �� 5      $	��190 �6   6+   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��40px �6#   62   �� 5      $
��40px �6#   62   �� 5      $
��40px �6#   62   �� 5      $
��40px �6#   62   �� 5      $	��10* �6#   61   �� 5      $
��40px �6#   62   .+�5      �� $	��←��6   $��0��6"   #��[" �62   $
��40px��6m   $
��30px��6z   $��0q�6�   
���   �$��18(�6�   6�   �� 5      $	��→��6   $��1��6"   #��[" �62   $
��40px��6m   $
��30px��6z   $��0q�6�   
���   �$��18(�6�   6�   �� 5       $	��⟳��6   $��2��6"   #��[" �62   $
��40px��6m   $
��30px��6z   $��0q�6�   
���   �$��18(�6�   6�   �� 5!      $	��⌂��6   $��3��6"   #��[" �62   $
��40px��6m   $
��30px��6z   $��0q�6�   
���   �$��18(�6�   6�   �� 5"      -   5         ��Name$
 area��5"   L   $3��-http://zdravokorporacija.com/add-announcement��6   $��4��6Z   
���   �$��15(�6}   $��SemiBold"�6�   $��	14 0 14 0q�6�   6�   �� 5#      $��search��6   $��5��6'   #��[" �67   $
��40px��6r   $
��30px��6   $��0q�6�   
���   �$��8(�6�   6�   5$      � 5%   
   $��1��6    5&      �� 5'      6&   �� 5(      6&   �� 5)      6&   �� 5*      6&   �� 5+      6&   �� 5,      6&   �� 5-      6&   �� 5.      6&   �� 5/      6&   �� 50      6&   .+�52      �� -   5        $
��Home��52      $��0��6%   #��[" �65   $��0q�6q   
���   �6�   �� 53      $��Patients��6   $��1��6)   #��[" �69   $��0q�6u   
���   �6�   �� 54      -   5        $��Appointments��54      $��2��6-   #��[" �6=   $��0q�6y   
���   �6�   �� 55      -   5        $��Rooms��55      $��3��6&   #��[" �66   $��0q�6r   
���   �6�   �� 56      -   5        $��new_patient_register��56      $��4��6a   
�������
�������#��["�6�   $��0q�6�   
���   �$	��0,5q�6  $	��100��6  .@�57      �� .��6    Guest account6/   �� 58      .��6   Regular account60   59      �� 5:      $��4��6   $��New patient��6$   $��Center=�6:   6Y   �� 5;      -   5        $��Graphs��5;      $��5��6'   #��[" �67   $��0q�6s   
���   �6�   �� 5<      -   5        $��Bulletin board��5<      $��6��6/   #��[" �6?   $��0q�6{   
���   �6�   �� 5=      -   5        $��	Emergency��5=      $��7��6*   #��[" �6:   $��0q�6v   
���   �6�   �� 5?      -	   5        $��Profile��5?      $��8��6(   #��[" �68   $��0q�6t   
���   �6�   �� 5@      -
   5        $��Log out��5@      $��9��6(   #��[" �68   $��0q�6t   
���   �6�   5A      � 5B   
   $��2��6   .+�5C      � .+�5D      !  FontAwesome.WPF.FontAwesome  $
��Left=�6!      Icon$ HospitalOutline=�6<   $��50(�6S   $��10,0,0,0q�6a   5E      �� 5F      $��Zdravo korporacija��6   $
��Left=�61   $��	51,15,0,0q�6L   $	��Top=�6_   5G      � 5H   
   $��3��6   .+�5I      �� -   5        $��titleAnnouncement��5I      $��15(�6/   $��20��6=   $	��150��6I   $��Center=�6U   $	��Top=�6r   5J      � 5K   
   $��4��6   .+�5L      �� -   5        $��textAnnouncement��5L      $��Center=�6/    �� TextWrapping$
 Wrap=�6L   $	��Top=�6a   $	��400��6y   $	��128��6�   5M      � 5N   
   $��5��6   .+�5O      �� -   5        $	��Add��5O      $��40��6#   $��Center=�6/   $	��Top=�6L   $	��176��6d   $��312,10,312,0q�6�   5Q      5R      5S      