   M S B A M L   `   `   `  ���� B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking      Booking.AdminBookingList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Booking       � Title$+  %Список бронирования��$	��740��$	��800��$	��540��$	��800��$
��1000��$	��800�� � Icon$ 	/icon.png�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ 	/fon8.jpg��.���  � ColumnDefinitions �� .+��� -    ��Name$ txtnameadmin��$��
Test Test ��$
��Left=�$��0,15,0,0q�$	��Top=����	#FF0495D8$��Center=�$��Center=����	#FF281A5D$
��Bold"�$��14(��� $��
30,40,0,65q�$
��Left=�$	��Top=�.+��� $	��168��$��Center=�$	��Top=�$	��400��$��0,0,0,30q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FF70B8DE��� $ 	#CC70B8DE��	 � Offset$	 1Q�.+��� $��Информация��$
��Bold"�
�������$	��400��$��Center=�$	��158��$��5,0,5,20q�$	��Top=�.���� 
 �� Orientation$
 Vertical=�.+��� $ ��Преподаватель�����	#FF003970$
��Bold"��� -    ��Name$ 
txtteacher�� �� TextWrapping$
 Wrap=�$�� �� �� 
IsReadOnly . �� $��Дата�����	#FF003970$
��Bold"��� -   $ txtdate��$
 Wrap=�$�� �� . �� $��
Время�����	#FF003970$
��Bold"��� -   $ txttime��$
 Wrap=�$�� �� . �� $#��Номер аудитории�����	#FF003970$
��Bold"��� -   $ 	txtnumber��$
 Wrap=�$�� �� . �� $��Этаж�����	#FF003970$
��Bold"��� -   $ txtfloor��$
 Wrap=�$�� �� . �� $��Предмет�����	#FF003970$
��Bold"��� -   $ 	txtlesson��$
 Wrap=�$�� �� . �� $��Тип занятия�����	#FF003970$
��Bold"��� -   $ txtlessontype�� . �� $
 Vertical=�$��Bottom=�$��Center=�.+��� -	    ��Name$ 	btndelete��$��Удалить��$��0,0,0,10q����	#E572B7E0$
��Bold"�$��14(����	#FF013870$	��168��$��Stretch=�$��40���� -
   $ 	btnreturn��$��
Назад�����	#FF469ECE���	#FF003970$��14(�$��40��$��0,0,0,0q�$
��Bold"�$	��168��$��Stretch=��� -    ��Name$ adminlistbooking��$	��540��$	��600��$��Right=�$	��Top=�$��	0,40,30,0q����	#CC469ECD �� View �� .P��� -   	idbooking�� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� -   	idteacher��$ ��Преподаватель��$
 auto�� �� $ Teacher��� -   date��$��Дата��$ 79�� �� $ Date_booking��� -   
idaudience��$��Аудитория��$ 79�� �� $ Audience��� -   
time_start��$��Начало��$ 79�� �� $ 
Time_start��� -   time_end��$��
Конец��$ 79�� �� $ Time_end�