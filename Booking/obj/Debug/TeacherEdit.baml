   M S B A M L   `   `   `  ����B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking  5   	       Booking.TeacherEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Booking     5   	     � Title$   Преподаватель��5   	   $	��610��6   $	��310��6,   $	��610��68   $	��310��6H   $	��610��6W   $	��310��6g    � WindowStartupLocation$ CenterScreen=�5	   	   ��5
      �� 5   
    �� ImageSource$ 	/fon4.jpg��6   .��5      � .+�5   
   �� $	��280��6   $	��510��6!   $��Center=�6.   $	��Top=�6K   $��0,10,0,0q�6c   ���	#B2D8F1FF.+�5      �� $	��160��6   $	��230��6&   .+�5      �� -   5         ��Name$ imgaddimage��5      $	��140��6-   $	��220��6:   $��0,15,0,0q�6F   5      �� 5      -   5        $��scroll��5      ��. $	��350��6A   .��5      �� $��Информация��6   $
��Bold"�6/   .��5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��Фамилия*��6    �� 5      -   5         ��Name$ txtaddfname��5   "    �� TextWrapping$
 Wrap=�67    �� 	MaxLength$ 25��6K   6Z   �� 5      $��Имя*��6    �� 5      -   5        $ txtaddsname��5   "   $
 Wrap=�67   $�� ��6K   $ 25��6S   6b   �� 5      $��Отчество*��6    �� 5      -   5        $ txtaddfathname��5   "   $
 Wrap=�6:   $�� ��6N   $ 25��6V   6e   �� 5      $��Должность��6    �� 5      -   5        $ txtaddposition��5   "   $
 Wrap=�6:   $�� ��6N   $	 255��6V   �� 5      $��Телефон��6    �� 5      -   5        $ 	txtaddtel��5   "   $
 Wrap=�65   $�� ��6I   $ 12��6Q   �� 5       $��Email��6    �� 5!      -   5        $ txtaddemail��5!   "   $
 Wrap=�67   $�� ��6K   $	 319��6S   �� 5$      $ 
Horizontal=�6%   $��0,10,0,0q�6>   $��Stretch=�6P   $��Center=�6n   .+�5%      �� $��Картинка��6$   �� 5&      -	   5        $��Center=�5&   %   $��Center=�6B   $��70��6]   $��	110,0,0,0q�6h   .��6�   Загрузить..6�   5'      �� 5(      -
   5        $ txtaddimage��5(   "   $
 Wrap=�67   $�� ��6K   $
 1000��6S   $��0,0,0,3q�6d   6u   5)      5*      5,      5-      �� 5/   
   $ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6I   $��0,0,0,5q�6f   $	��287��6w   .+�50      �� -   5         ��Name$ 
btnaddEdit��50      $��Сохранить��6)   $��5,5,5,5q�6=   $��126.5��6N   ���	#CC37A3D8$
��Bold"�6s   $��14(�6�   $��30��6�   $��Center=�6�   $��Center=�6�   {�.  6�   �� 51      -   5        $ 	btncancel��51      $��Отменить��6(   $��10,5,5,5q�6;   $��126.5��6M   ���	#CC37A3D8$
��Bold"�6r   $��14(�6�   $��30��6�   $��Center=�6�   $��Center=�6�   52      53      54      