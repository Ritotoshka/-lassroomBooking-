   M S B A M L   `   `   `  ���� B  >Booking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BookingBooking      Booking.BookingList   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Booking       � Title$+  %Список бронирования��$	��540��$	��600��$	��540��$	��600��$	��540��$	��600�� � Icon$ 	/icon.png�� � WindowStartupLocation$ CenterScreen=�����  �� ImageSource$ 	/fon8.jpg��.���  � ColumnDefinitions �� .+��� -    ��Name$ txtnameteacher��$��
Test Test ��$
��Left=�$��0,15,0,0q�$	��Top=����	#FF0495D8$��Center=�$��Center=����	#FF281A5D$
��Bold"�$��14(��� $��50�� �� Orientation$ 
Horizontal=�$	��540��$��Bottom=�$
��Left=�$��
30,0,30,10q�.+��� -    ��Name$ 	btnreturn��$��
Назад�����	#FF469ECE���	#FF003970$��14(�$��40��$��0,5,5,5q�$
��Bold"�$	��168��$
��Left=��� -   $ btnaddbooking��$ ��Забронировать��$��18,5,5,5q����	#E572B7E0$
��Bold"����	#FF013870$	��160��$��Right=�$��14(��� -   $ 	btndelete��$��Удалить��$��7,5,0,5q����	#E572B7E0$
��Bold"�$��14(����	#FF013870$	��160��$��Right=��� $	��168��$
��Left=�$��Bottom=�$��
30,30,0,65q�$	��400������  �� EndPoint$ 0.5,1&�	 �� 
StartPoint$	 0.5,0&�.��� 
 � Color$
 	#FF70B8DE��� $
 	#CC70B8DE�� � Offset$ 1Q�.+��� $��Информация��$
��Bold"�
�������$	��400��$��Center=�$	��158��$��5,0,5,0q�$��Center=�.���� $ Vertical=�.+��� $��Дата�����	#FF003970$
��Bold"��� -    ��Name$ txtdate�� �� TextWrapping$
 Wrap=�$�� �� �� 
IsReadOnly . �� $��
Время�����	#FF003970$
��Bold"��� -   $ txttime��$
 Wrap=�$�� �� . �� $#��Номер аудитории�����	#FF003970$
��Bold"��� -   $ 	txtnumber��$
 Wrap=�$�� �� . �� $��Этаж�����	#FF003970$
��Bold"��� -   $ txtfloor��$
 Wrap=�$�� �� . �� $��Предмет�����	#FF003970$
��Bold"��� -	   $ 	txtlesson��$
 Wrap=�$�� �� . �� $��Тип занятия�����	#FF003970$
��Bold"��� -
   $ txtlessontype�� . �� -    ��Name$ listbooking��$	��340��$	��400��$��Right=�$��Bottom=�$��	0,0,30,65q����	#CC469ECD �� View �� .P��� -   	idbooking�� �� Width$ 0�� �� DisplayMemberBinding ��  �� Path$ Id��� -   date��$��Дата��$ 79�� �� $ Date_booking��� -   
idaudience��$��Аудитория��$ 79�� �� $ Audience��� -   
time_start��$��Начало��$ 79�� �� $ 
Time_start��� -   time_end��$��
Конец��$ 79�� �� $ Time_end�