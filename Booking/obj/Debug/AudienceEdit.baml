   M S B A M L   `   `   `  ����B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking  5   	       Booking.AudienceEdit   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Booking     5   	     � Title$  Аудитория��5   	   $	��430��6   $	��310��6(   $	��300��64   $	��310��6D   $	��430��6S   $	��310��6c    � WindowStartupLocation$ CenterScreen=�5	   	   ��5
      �� 5   
    �� ImageSource$ 	/fon4.jpg��6   .��5      � .+�5   
   �� $	��280��6   $��Center=�6!   $	��Top=�6>   $��0,10,0,0q�6V   ���	#B2D8F1FF$	��335��6   .+�5      �� -   5        $��scroll��5      ��. .��5      �� $��Информация��6   $
��Bold"�6/   .��5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $$��Номер аудитории*��6    �� 5      -   5         ��Name$ txtaddnumber��5   "    �� TextWrapping$
 Wrap=�68   $�� ��6L    �� 	MaxLength$ 5��6T   6b   �� 5      $��	Этаж*��6    �� 5      -   5         ��Name$ 
list_floor��5   #     �� IsTextSearchCaseSensitive . 	 �� 
IsEditable	 . 6�   �� 5      $��Инвентарь��6    �� 5      -   5        
 ��Name$
 stackpanel_inventory��5   %   $��16,0,0,0q�6C   5      5      5      5      5      �� 5    
   $ 
Horizontal=�6   $��Bottom=�6.   $��Center=�6I   $��0,0,0,5q�6f   $	��287��6w   .+�5!      �� -   5         ��Name$ 
btnaddEdit��5!      $��Сохранить��6)   $��5,5,5,5q�6=   $��126.5��6N   ���	#CC37A3D8$
��Bold"�6s   $��14(�6�   $��30��6�   $��Center=�6�   $��Center=�6�   {�.  6�   �� 5"      -   5        $ 	btncancel��5"      $��Отменить��6(   $��10,5,5,5q�6;   $��126.5��6M   ���	#CC37A3D8$
��Bold"�6r   $��14(�6�   $��30��6�   $��Center=�6�   $��Center=�6�   5#      5$      5%      