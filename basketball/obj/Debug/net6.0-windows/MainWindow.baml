   M S B A M L   `   `   `  ����E  Abasketball, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:basketball
basketball  5   	       basketball.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:basketball     5   	   -   5          � Title$  Basketball modeling��5   	      mainWindowStyle#���   5	   	    � Icon$ Resources/ball.png��6J    � 	Resources 5
       �� Source�� 5   
   $ 
style.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $	��22* �6   $	��250��6+   �� 5      $	��78* �6   �� 5      $��0* �6   .+�5   
   � -   5         �Name$ navigationGrid��5      $��0��6'     navigationBarStyle#���  67   .+�5      �� .+�5      �� $��Resources/logo2.png��6   $��Center=�65   $��85��6R   $��0 20 0 0q�6^   �� 5      $��
15 100 0 0q�6    �� TextAlignment$
 Left=�60   $��Разделы��6E     header2#���  6T   �� 5      -   5         ��Name$ 
mainButton��5      $��0 20 0 0q�6-     navigationButtonStyle#���  6Y   .��5      �� -   5         ��Name$ mainStackPanel��5   !   	 �� Orientation$	 
Horizontal=�6:   .+�5      �� -   5        
 ��Name$
 	mainImage��5       $ ��Resources/infoOrdinary.png��63   $
��Left=�6W   $��20��6r   $��15 0 0 0q�6~   $��Center=�6�   �� 5      -   5         ��Name$ mainTextBlock��5   $   $��Главная��6;   $��Center=�6J   $
��Left=�6e   $��12 4 0 0q�6�   5      5      �� 5      -   5        $ modelingButton��5      $��0 10 0 0q�61   #���  6C   .��5      �� -   5        $ modelingStackPanel��5   !   $	 
Horizontal=�6=   .+�5       �� -	   5        $
 modelingImage��5        $%��Resources/calculateOrdinary.png��67   $
��Left=�6`   $��20��6{   $��15 0 0 0q�6�   $��Center=�6�   �� 5!      -
   5        $ modelingTextBlock��5!   $   $ ��Моделирование��6?   $��Center=�6T   $
��Left=�6o   $��12 4 0 0q�6�   5"      5#      �� 5$      -   5        $ detailsButton��5$      $��0 10 0 0q�60   #���  6B   .��5%      �� -   5        $ detailsStackPanel��5%   !   $	 
Horizontal=�6<   .+�5&      �� -   5        $
 detailsImage��5&       $#��Resources/detailsOrdinary.png��66   $
��Left=�6]   $��20��6x   $��15 0 0 0q�6�   $��Center=�6�   �� 5'      -   5        $ detailsTextBlock��5'   $   $��Подробности��6>   $��Center=�6Q   $
��Left=�6l   $��12 3 0 0q�6�   5(      5)      �� 5*      -   5        $ test1��5*      $��
40 20 20 0q�6+   $
��Wrap=�6?   $
 Left=�6S     header3#���  6h   �� 5+      -   5        $ test2��5+      $��
40 20 20 0q�6+   $
��Wrap=�6?   $
 Left=�6S   #���  6h   �� 5,      -   5        $ test3��5,      $��
40 20 20 0q�6+   $
��Wrap=�6?   $
 Left=�6S   #���  6h   5-      5.      � 50   
   -   5        $ mainPageGrid��50      $��0 50 0 0q�6%   $��1��67   .+�51      �� .��52      �� -   5        $ mainPageStackPanel��52      $��20q�69   $
��1400��6E   $��Center=�6U   .+�53      �� $��20 20 20 10q�6    $
 Left=�65   $��Возможности��6J    
 header#���  6]   �� 54      $	 
Horizontal=�6!   .+�55      �� -   5         ��Name$ 	function1��55   !   $��10q�64    �� CornerRadius$ 10��6@   $	��200��6R     	cardStyle#���  6�   ._�56      �� .+�57   "   �� -   5        $ function1Text��57   ,   $��20 20 20 10q�6C   $
��Wrap=�6X   $ Center=�6l   $J��DОпределение попадания мяча в корзину��6�   #���  6�   �� 58   "   -   5        $
 function1Image��58   (   $��Resources/basketGray.png��6@   $��Center=�6b   $��10q�6   59      5:      �� 5;      -   5        $ 	function2��5;   !   $��10q�64   $ 10��6@   $	��200��6R   #���  6�   ._�5<      �� .+�5=   "   �� -   5        $ function2Text��5=   ,   $��20 20 20 10q�6C   $
��Wrap=�6X   $ Center=�6l   $c��]Вычисление максимальной высоты и дальности полета��6�   #���  6�   �� 5>   "   -   5        $
 function2Image��5>   (   $��Resources/sizeGray.png��6@   $��Center=�6`   $��10q�6}   5?      5@      �� 5A      -   5        $ 	function3��5A   !   $��10q�64   $ 10��6@   $	��200��6R   #���  6�   ._�5B      �� .+�5C   "   �� -   5        $ function3Text��5C   ,   $��20 20 20 10q�6C   $
��Wrap=�6X   $ Center=�6l   $1��+Отображение траектории��6�   #���  6�   �� 5D   "   -   5        $
 function3Image��5D   (   $"��Resources/trajectoryGray.png��6@   $��Center=�6f   $��10q�6�   5E      5F      5G      5H      5I      5J      � 5L   
   -   5        $ modelingPageGrid��5L      $��0 50 0 0q�6)   $��1��6;   .+�5M      �� .��5N      �� -   5        $ modelingPageStackPanel��5N      $
��1400��6=   $��Center=�6M   $��20q�6j   .+�5O      �� $��20 20 20 10q�6    $
 Left=�65   $!��Входные данные��6J   #���  6`   �� 5P      .+�5Q      �� $	 
Horizontal=�6%   .+�5R      �� -   5        $ variablesCard��5R   %   $��10q�6<   $ 10��6H   $	��560��6Z   #���  6g   ._�5S   "   �� $	 Vertical=�6-   .+�5T   &   �� -    5        $ variablesCardText��5T   0   $��
20 20 20 0q�6K   $
��Wrap=�6_   $
 Left=�6s   $��Переменные��6�   #���  6�   �� 5U   &   $	 Vertical=�61   .+�5V   *   �� $��
0 40 110 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Center=�6q   $0��*Начальная скорость, м/с��6�     description#���  6�   �� 5W   *   -!   5         ��Name$ initialSpeed��5W   2   $	��200��6H   $��10q�6T   $��Center=�6`   $��10��6}   5X   '   �� 5Y   &   $	 Vertical=�61   .+�5Z   *   �� $��
0 10 170 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Center=�6q   $��Рост игрока, м��6�   #���  6�   �� 5[   *   -"   5        $ initialHeight��5[   2   $	��200��6I   $��10q�6U   $��Center=�6a   $
��1,82��6~   5\   '   �� 5]   &   $	 Vertical=�61   .+�5^   *   �� $��
0 10 160 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Center=�6q   $"��Угол броска α, °��6�   #���  6�   �� 5_   *   -#   5        $ initialAngleA��5_   2   $	��200��6I   $��10q�6U   $��Center=�6a   $��42��6~   5`   '   �� 5a   &   $	 Vertical=�61   .+�5b   *   �� $��
0 10 160 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Center=�6q   $"��Угол броска β, °��6�   #���  6�   �� 5c   *   -$   5        $ initialAngleB��5c   2   $	��200��6I   $��10q�6U   $��Center=�6a   $��97��6~   5d   '   �� 5e   &   $	 Vertical=�61   .+�5f   *   �� -%   5        $ ballType��5f   4   $��
0 10 200 0q�6F   $
��Wrap=�6Z   $
 Left=�6n   $��Center=�6�   $��Тип мяча��6�   #���  6�   �� 5g   *   -&   5         ��Name$ ballTypeValue��5g   4   $	��200��6K   $��10q�6W   .@�5h   .   �� -'   5         ��Name$ 	ballType7��5h   ;    �� 
IsSelected$
 True��6N   .��5i   2   �� .+�5j   6   �� $��Размер 7��6@   $��2q�6P   #���  6[   �� 5k   6   $��650 г��6@   $��11(�6M   ���#878683#���  6p   5l   3   5m   /   �� 5n   .   -(   5        $ 	ballType6��5n   ;   .��5o   2   �� .+�5p   6   �� $��Размер 6��6@   $��2q�6P   #���  6[   �� 5q   6   $��567 г��6@   $��11(�6M   ���#878683#���  6p   5r   3   5s   /   �� 5t   .   -)   5        $ 	ballType5��5t   ;   .��5u   2   �� .+�5v   6   �� $��Размер 5��6@   $��2q�6P   #���  6[   �� 5w   6   $��500 г��6@   $��11(�6M   ���#878683#���  6p   5x   3   5y   /   �� 5z   .   -*   5        $ 	ballType3��5z   ;   .��5{   2   �� .+�5|   6   �� $��Размер 3��6@   $��2q�6P   #���  6[   �� 5}   6   $��330г��6@   $��11(�6L   ���#878683#���  6o   5~   3   5   /   5�   +   5�   '   �� 5�   &   $	 Vertical=�61   .+�5�   *   �� -+   5        $ ringNumText��5�   4   $��
0 10 205 0q�6I   $
��Wrap=�6]   $
 Left=�6q   $��Center=�6�   $��Кольцо��6�   #���  6�   �� 5�   *   -,   5        $ ringNum��5�   4   $	��200��6E   $��10q�6Q   .@�5�   .   �� --   5        $ 	rightRing��5�   ;   $
 True��6N   .��5�   2   �� .+�5�   6   �� $��Правое��6@   $��2q�6N   #���  6Y   5�   3   5�   /   �� 5�   .   -.   5        $ leftRing��5�   ;   .��5�   2   �� .+�5�   6   �� $��
Левое��6@   $��2q�6M   #���  6X   5�   3   5�   /   5�   +   5�   '   5�   #   5�      �� 5�      -/   5        $ parametersCard��5�   %   $��10q�6=   $ 10��6I   $	��560��6[   #���  6h   ._�5�   "   �� .+�5�   &   �� -0   5        $ parametersText��5�   0   $��
20 20 20 0q�6H   $
��Wrap=�6\   $
 Left=�6p   $��Параметры��6�   #���  6�   �� 5�   &   $	 Vertical=�61   .+�5�   *   �� $	 Vertical=�65   .+�5�   .   �� $��
0 40 105 0q�68   $
��Wrap=�6L   $
 Left=�6`   $��Center=�6u   $1��+Плотность воздуха, кг/м3��6�   #���  6�   �� 5�   .   -1   5        $ 
airDensity��5�   6   $	��200��6K   $��10q�6W   $��Center=�6c   $��1,2041��6�   ${�False��6�   5�   +   �� 5�   *   $	 Vertical=�65   .+�5�   .   �� $��
0 10 152 0q�68   $
��Wrap=�6L   $
 Left=�6`   $��Center=�6u   $!��Коэффициент АС��6�   #���  6�   �� 5�   .   -2   5        $ сCoefficient��5�   6   $	��200��6L   $��10q�6X   $��Center=�6d   $
��0,47��6�   ${�False��6�   5�   +   �� 5�   *   $	 Vertical=�65   .+�5�   .   �� $��
0 10 135 0q�68   $
��Wrap=�6L   $
 Left=�6`   $��Center=�6u   $%��Диаметр кольца, м��6�   #���  6�   �� 5�   .   -3   5        $ basketDiameter��5�   6   $	��200��6N   $��10q�6Z   $��Center=�6f   $
��0,46��6�   ${�False��6�   5�   +   �� 5�   *   $	 Vertical=�65   .+�5�   .   �� $��
0 10 145 0q�68   $
��Wrap=�6L   $
 Left=�6`   $��Center=�6u   $#��Высота кольца, м��6�   #���  6�   �� 5�   .   -4   5        $ basketHeight��5�   6   $	��200��6M   $��10q�6Y   $��Center=�6e   $
��3,05��6�   ${�False��6�   5�   +   5�   '   5�   #   5�      5�      �� 5�      -5   5        $ positionCard��5�   !   $��10q�67   $ 10��6C   $	��500��6U   #���  6b   ._�5�      �� $	 Vertical=�6)   .+�5�   "   �� -6   5        $ positionText��5�   ,   $��
20 20 20 0q�6B   $
��Wrap=�6V   $
 Left=�6j   $'��!Начальная позиция��6   #���  6�   � 5�   "   -7   5        $ positionGrid��5�   '    5�   &   �� 5�   *   $	��20* �6;   �� 5�   *   $	��60* �6;   �� 5�   *   $	��20* �6;    � RowDefinitions 5�   &   �� 5�   *   $
��1.5* �68   �� 5�   *   $��5* �68   �� 5�   *   $
��1.5* �68   .+�5�   &   �� $��	0 20 0 0 q�61   $��0��6D   $��1��6Q   $��Center=�6a   $	 
Horizontal=�6~   .+�5�   *   �� $	 Vertical=�65   .+�5�   .   �� $��
0 10 120 0q�68   $
��Wrap=�6L   $
 Left=�6`   $��Center=�6u   $��X, м��6�   #���  6�   �� 5�   .   -8   5        $ initialX��5�   6   $	��150��6H   $��40 10q�6T   $��Center=�6c   $	��9,5��6�   6�   5�   +   �� 5�   *   $	 Vertical=�65   .+�5�   .   �� $��
0 10 120 0q�68   $
��Wrap=�6L   $
 Left=�6`   $��Center=�6u   $��Y, м��6�   #���  6�   �� 5�   .   -9   5        $ initialY��5�   6   $	��150��6H   $��40 10q�6T   $��Center=�6c   $��10��6�   6�   5�   +   5�   '   �� 5�   &   -:   5        $
 positionGraphImage��5�   I   $��1��6,   $��1��6<   $��30q�6e   $��Bottom=�6q   $	��250��6�   �� 5�   &   -;   5         ��Name$ xPositionSlider��5�   -   $��0��6F   $��1��6V    � Value$ 0Q�6c   $��10 30q�6m    �� Orientation$ Vertical=�6|   $��Bottom=�6�   $��Right=�6�    � Minimum$ 0Q�6�    � Maximum$ 15Q�6�    �� TickPlacement$ BottomRight=�6�   
���   �6  �� 5�   &   -<   5        $ yPositionSlider��5�   -   $��1��6F   $��2��6V   $ 0Q�6c   $	��0 5q�6m   $ 
Horizontal=�6z   $	��Top=�6�   $ 0Q�6�   $ 28Q�6�   $ TopLeft=�6�   
���   �6�   5�   #   5�      5�      5�      �� 5�      -=   5        $ stepCard��5�      $��10q�6/   $ 10��6;   $	��230��6M   #���  6Z   ._�5�      �� .+�5�      �� ->   5        $ stepText��5�   (   $��
20 20 20 0q�6:   $
��Wrap=�6N   $
 Left=�6b   $3��-Дополнительные сведения��6w   #���  6�   �� 5�      $	 Vertical=�6)   .+�5�   "   �� $��
0 45 100 0q�6,   $
��Wrap=�6@   $
 Left=�6T   $��Center=�6i   $'��!Шаг моделирования��6�   #���  6�   �� 5�   "   -?   5        $ 	stepValue��5�   *   $	��200��6=   $��10q�6I   $��Center=�6U   $	��0,1��6r   �� 5�   "   -@   5         ��Name$ linesCheckBox��5�   +   $��	0 25 5 25q�6B   $9��3Отображать сетку на графике��6U    d� 	IsChecked$
 TrueY�6{   5�      5�      5�      �� 5�      $	 
Horizontal=�6!   .+�5�      �� -A   5        $ calculatetButton��5�   !   $��Рассчитать��6;   $��10q�6P     calculateButtonStyle#���  6\   6�   5�      �� 5�      -B   5        $ valuesStackPanel��5�   !   $	 Vertical=�6;   $y�Hidden=�6R   .+�5�      �� $��20 70 20 10q�6$   $
 Left=�69   $��Показатели��6N   #���  6`   �� 5�      -C   5        $ valuesCardsStackPanel��5�   %   $	 
Horizontal=�6D   .+�5�      �� $	 
Horizontal=�6)   .+�5�   "   �� -D   5        $ successCard��5�   )   $��10q�6>   $ 10��6J   $	��150��6\   #���  6i   ._�5�   &   �� .+�5�   *   �� -E   5        $ successText��5�   4   $��
20 20 20 0q�6I   $
��Wrap=�6]   $
 Left=�6q   $��Попадание��6�   #���  6�   �� 5�   *   -F   5        $ 	hitStatus��5�   4   $��20(�6G   $��Regular"�6U   $��	0 30 0 40q�6j   $��Center=�6}   $
��Wrap=�6�   $ Center=�6�   $��-��6�   #���  6�   5�   '   5�   #   �� 5�   "   -G   5        $ maxHeightCard��5�   )   $��10q�6@   $ 10��6L   $	��150��6^   #���  6k   ._�5�   &   �� .+�5�   *   �� -H   5        $ maxHeighText��5�   4   $��
20 20 20 0q�6J   $
��Wrap=�6^   $
 Left=�6r   $+��%Максимальная высота��6�   #���  6�   �� 5�   *   -I   5        $ maxHeightValue��5�   4   $��20(�6L   $��Regular"�6Z   $��	0 30 0 40q�6o   $��Center=�6�   $
��Wrap=�6�   $ Center=�6�   $��	H = 15 м��6�   #���  6�   5�   '   5�   #   5�      �� 5�      $	 
Horizontal=�6)   .+�5�   "   �� -J   5        $ distanceCard��5�   )   $��10q�6?   $ 10��6K   $	��150��6]   #���  6j   ._�5�   &   �� .+�5�   *   �� -K   5        $ distanceText��5�   4   $��
20 20 20 0q�6J   $
��Wrap=�6^   $
 Left=�6r   $%��Дальность полета��6�   #���  6�   �� 5�   *   -L   5        $ distanceValue��5�   4   $��20(�6K   $��Regular"�6Y   $��	0 30 0 40q�6n   $��Center=�6�   $
��Wrap=�6�   $ Center=�6�   $��
L = 101 м��6�   #���  6�   5�   '   5�   #   �� 5�   "   -M   5        $ timeCard��5�   )   $��10q�6;   $ 10��6G   $	��150��6Y   #���  6f   ._�5�   &   �� .+�5�   *   �� -N   5        $ timeText��5�   4   $��
20 20 20 0q�6F   $
��Wrap=�6Z   $
 Left=�6n   $��Время полета��6�   #���  6�   �� 5�   *   -O   5        $ 	timeValue��5�   4   $��20(�6G   $��Regular"�6U   $��	0 30 0 40q�6j   $��Center=�6}   $
��Wrap=�6�   $ Center=�6�   $��T = 1 c��6�   #���  6�   5�   '   5�   #   5�      5�      5�      �� 5�      -P   5        $ trajectoryStackPanel��5�   !   $	 Vertical=�6?   $y�Hidden=�6V   .+�5�      �� $��20 70 20 10q�6$   $
 Left=�69   $'��!Траектория полета��6N   #���  6g   �� 5�      -Q   5        $ trajectoryCard��5�   !   $��	5 10 5 50q�69   $ 10��6L   $	��550��6^   #���  6k   ._�5�      �� .+�5�   "   �� -R   5        $ trajectoryGraphImageText��5�   ,   $��
30 30 30 0q�6N   $
��Wrap=�6b   $
 Left=�6v   $
��Z(Y)��6�   #���  6�   �� 5�   "   -S   5        $
 trajectoryGraphImage��5�   (   $��50q�6F    		 graph#��� 	 6R    K� ZIndex$ 2��6r   5�      5�      �� 5      -T   5        $ trajectoryCard2��5   !   $��	5 10 5 50q�6:   $ 10��6M   $	��550��6_   #���  6l   ._�5     �� .+�5  "   �� -U   5        $ trajectoryGraphImage2Text��5  ,   $��
30 30 30 0q�6O   $
��Wrap=�6c   $
 Left=�6w   $
��X(Y)��6�   #���  6�   �� 5  "   -V   5        $
 trajectoryGraphImage2��5  (   $��50q�6G   #��� 	 6S   $ 2��6s   5     5     5     �� 5     -W   5        $ resultStackPanel��5  !   $	 Vertical=�6;   $y�Hidden=�6R   .+�5     �� $��20 70 20 10q�6$   $
 Left=�69   $+��%Численный результат��6N   #���  6i   �� 5	     -X   5        $ 
resultCard��5	  !   $��10 10 10 100q�65   $ 10��6K   #���  6]   ._�5
     �� .+�5  "   �� -Y   5        $ 
resultText��5  ,   $��
20 20 20 0q�6@   $
��Wrap=�6T   $
 Left=�6h   $%��Таблица значений��6}   #���  6�   �� 5  "   $��10q�6)   $ 10��65   ._�5  &   � .+�5  *   �� -Z   5        $ 	BDRounded��5  1   $��1q�6D   ���#e5e5e5$ 10��6n   
�������6�   &   System.Windows.Controls.DataGrid  5  *   -[   5          Name$ 	dataTable��5  3   $��70 30q�6|   ��6�   Z�  J� OpacityMask 5  .   !� 5  2    !� Visual 6>   ��  �� ElementName$ 	BDRounded��5  +   5  '   5  #   5     5     5     5     5     5     � 5  
   -\   5        $ detailsPageGrid��5     $��0 50 0 0q�6(   $��1��6:   .+�5     �� .��5     �� -]   5        $ detailsPageStackPanel��5     $
��1400��6<   $��Center=�6L   $��20q�6i   .+�5!     �� $��20 20 20 10q�6    $
 Left=�65   $%��Описание объекта��6J   #���  6b   �� 5"     $	 
Horizontal=�6!   .+�5#     �� -^   5        $ modelDescriptionCard��5#  !   $��10q�6?   $ 10��6K   #���  6]   ._�5$     �� $	 Vertical=�6)   .+�5%  "   �� -_   5        $ modelDescriptionText1��5%  ,   $
��Auto��6K   $��40 40 40 10q�6Y   $
��Wrap=�6n   $ Justify=�6�   $
��Left=�6�     �� 
LineHeight$  21��6�   #���  6�   $����В качестве объекта моделирования выступает баскетбольный мяч заданного типа, брошенный с начальной скоростью под углами к осям X и Z. С течением времени свойства объекта не меняются, изменениям подвержены лишь его скорость и координаты в пространстве.��5&  0   �� 5'  "   -`   5        $ modelDescriptionText2��5'  ,   $
��Auto��6K   $��40 10 40 40q�6Y   $
��Wrap=�6n   $ Justify=�6�   $
��Left=�6�   $  21��6�   #���  6�   $����Бросок осуществляется с определенной высоты (в переложении на реальные обстоятельства – роста человека, выполняющего его) и позиции на баскетбольной площадке в кольцо, координаты центра которого известны заранее.��5(  0   5)     5*     �� 5+     -a   5        $ ballsStackPanel��5+  %   $	 
Horizontal=�6>   .+�5,     �� $	 
Horizontal=�6)   .+�5-  "   �� -b   5        $ 	ball7Card��5-  )   $��10q�6<   $ 10��6H   #���  6Z   ._�5.  &   �� $	 Vertical=�61   .+�5/  *   �� $��
20 20 20 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Размер 7��6q   #���  6�   �� 50  *   -c   5        $
 
ball7Image��50  0   $��Resources/ball7.png��6D   $��Center=�6a   51  '   52  #   �� 53  "   -d   5        $ 	ball6Card��53  )   $��10q�6<   $ 10��6H   #���  6Z   ._�54  &   �� $	 Vertical=�61   .+�55  *   �� $��
20 20 20 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Размер 6��6q   #���  6�   �� 56  *   -e   5        $
 
ball6Image��56  0   $��Resources/ball6.png��6D   $��Center=�6a   57  '   58  #   59     �� 5:     $	 
Horizontal=�6)   .+�5;  "   �� -f   5        $ 	ball5Card��5;  )   $��10q�6<   $ 10��6H   #���  6Z   ._�5<  &   �� $	 Vertical=�61   .+�5=  *   �� $��
20 20 20 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Размер 5��6q   #���  6�   �� 5>  *   -g   5        $
 
ball5Image��5>  0   $��Resources/ball5.png��6D   $��Center=�6a   5?  '   5@  #   �� 5A  "   -h   5        $ 	ball3Card��5A  )   $��10q�6<   $ 10��6H   #���  6Z   ._�5B  &   �� $	 Vertical=�61   .+�5C  *   �� $��
20 20 20 0q�64   $
��Wrap=�6H   $
 Left=�6\   $��Размер 3��6q   #���  6�   �� 5D  *   -i   5        $
 
ball3Image��5D  0   $��Resources/ball3.png��6D   $��Center=�6a   5E  '   5F  #   5G     5H     5I     �� 5K     $��20 70 20 10q�6    $
 Left=�65   $+��%Параметры окружения��6J   #���  6e   �� 5L     .+�5M     �� $��0 10 0 0q�6!   $	 
Horizontal=�63   .+�5N     �� $	 Vertical=�6%   .+�5O     �� -j   5        $ backboardSizeCard��5O  %   $��10q�6@   $ 10��6L   #���  6^   ._�5P  "   �� $	 Vertical=�6-   .+�5Q  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $��Размеры щита��6m   #���  6�   �� 5R  *   -k   5        $
 backboardSizeImage��5R  0   $!��Resources/backboardSize.png��6L   $��Center=�6q   $��40 40 50 40q�6�   $	��320��6�   5S  #   5T     �� 5U     -l   5        $ ringSizeCard��5U  %   $��10q�6;   $ 10��6G   #���  6Y   ._�5V  "   �� $	 Vertical=�6-   .+�5W  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $!��Размеры кольца��6m   #���  6�   �� 5X  *   $��Resources/ringSize.png��60   $��Center=�6P   $��
60 40 60 0q�6m   $	��300��6�   5Y  #   5Z     5[     �� 5\     -m   5        $ basketSizeCard��5\  !   $��10q�69   $ 10��6E   $	��600��6W   #���  6d   ._�5]     �� $	 Vertical=�6)   .+�5^  "   �� $��
20 20 20 0q�6,   $
��Wrap=�6@   $
 Left=�6T   $��Высота кольца��6i   #���  6~   �� 5_  &   $��Resources/basketSize.png��6,   $��Center=�6N   $��10 80 10 30q�6k   $	��310��6�   5`     5a     5b     �� 5c     $	 
Horizontal=�6%   .+�5d     �� -n   5        $ 	fieldCard��5d  %   $��10q�68   $ 10��6D   #���  6V   ._�5e  "   �� $	 Vertical=�6-   .+�5f  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $0��*Координаты на площадке��6m   #���  6�   �� 5g  &   $��Resources/field.png��6,   $��Center=�6I   $��40 40 40 50q�6f   $	��600��6{   5h  #   5i     �� 5j     -o   5        $ fieldSizeCard��5j  %   $��10q�6<   $ 10��6H   #���  6Z   ._�5k  "   �� $	 Vertical=�6-   .+�5l  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $%��Размеры площадки��6m   #���  6�   �� 5m  &   $��Resources/fieldSize.png��6,   $��Center=�6M   $��40 40 40 50q�6j   $	��600��6   5n  #   5o     5p     5q     �� 5s     -p   5        $ hitDiscription��5s     $��10q�65   $ 10��6A   #���  6S   ._�5t     �� $	 Vertical=�6%   .+�5u     �� $��20 20 20 10q�6(   $
��Wrap=�6=   $
 Left=�6Q   $)��#Фиксация попадания��6f   #���  6�   �� 5v     -q   5        $ hitDiscriptionText��5v  (   $
��Auto��6D   $��40 20q�6R   $
��Wrap=�6a   $ Justify=�6u   $
��Left=�6�   $  21��6�   #���  6�   $����Для фиксации попадания мяча в кольцо осуществляется проверка принадлежности координат его центра заданному интервалу в окрестностях центра кольца. То есть, определяется принадлежность точки шару с известным радиусом.��5w  0   5x     5y     �� 5z     -r   5        $ hitCardsStackPanel��5z  !   $��0 0 0 50q�6=   .+�5{     �� $	 
Horizontal=�6%   .+�5|     �� -s   5        $ hitCard7��5|  %   $��10q�67   $ 10��6C   #���  6U   ._�5}  "   �� $	 Vertical=�6-   .+�5~  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $��Размер 7��6m   #���  6}   �� 5  &   -t   5        $
 	hit7Image��5  ,   $��Resources/hit7.png��6?   $��20q�6[   $	��300��6g   5�  #   5�     �� 5�     -u   5        $ hitCard6��5�  %   $��10q�67   $ 10��6C   #���  6U   ._�5�  "   �� $	 Vertical=�6-   .+�5�  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $��Размер 6��6m   #���  6}   �� 5�  &   -v   5        $
 	hit6Image��5�  ,   $��Resources/hit6.png��6?   $��20q�6[   $	��300��6g   5�  #   5�     5�     �� 5�     $	 
Horizontal=�6%   .+�5�     �� -w   5        $ hitCard5��5�  %   $��10q�67   $ 10��6C   #���  6U   ._�5�  "   �� $	 Vertical=�6-   .+�5�  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $��Размер 5��6m   #���  6}   �� 5�  &   -x   5        $
 	hit5Image��5�  ,   $��Resources/hit5.png��6?   $��20q�6[   $	��300��6g   5�  #   5�     �� 5�     -y   5        $ hitCard3��5�  %   $��10q�67   $ 10��6C   #���  6U   ._�5�  "   �� $	 Vertical=�6-   .+�5�  &   �� $��
20 20 20 0q�60   $
��Wrap=�6D   $
 Left=�6X   $��Размер 3��6m   #���  6}   �� 5�  &   -z   5        $
 	hit3Image��5�  ,   $��Resources/hit3.png��6?   $��20q�6[   $	��300��6g   5�  #   5�     5�     5�     �� 5�     $��20 50 20 10q�6    $
 Left=�65   $V��PЯвления и процессы, происходящие на объекте��6J   #���  6}   �� 5�     $	 
Horizontal=�6!   .+�5�     �� -{   5        $! nonSignificantPhenomenaCard��5�  !   $��10q�6F   $ 10��6R   $	��500��6d   #���  6q   ._�5�     �� .+�5�  "   �� -|   5        $! nonSignificantPhenomenaText��5�  ,   $��
20 20 20 0q�6Q   $
��Wrap=�6e   $
 Left=�6y   $��Существенные��6�   #���  6�   �� 5�  "   -}   5        $" nonSignificantPhenomenaText2��5�  ,   $
��Auto��6R   $��40 30 40 10q�6`   $
��Wrap=�6u   $ Justify=�6�   $��Center=�6�   $  25��6�   #���  6�   $p��j• гравитация;
• сопротивение воздуха;;
• законы механики.��5�  0   5�     5�     �� 5�     -~   5        $ significantPhenomenaCard��5�  !   $��10q�6C   $ 10��6O   $	��500��6a   #���  6n   ._�5�     �� .+�5�  "   �� -   5        $ significantPhenomenaText��5�  ,   $��
20 20 20 0q�6N   $
��Wrap=�6b   $
 Left=�6v   $"��Несущественные��6�   #���  6�   �� 5�  "   -�   5        $ significantPhenomenaText2��5�  ,   $
��Auto��6O   $��40 30 40 10q�6]   $
��Wrap=�6r   $ Justify=�6�   $��Center=�6�   $  25��6�   #���  6�   $����• изменение плотности воздуха (мяч не может достигнуть высоты, плотность воздуха на которой влияет на результат моделирования);
• ветер (бросок выполняется в закрытом помещении, порывы ветра в котором отсутствуют);
• внешние помехи (человек, выполняющий бросок, стоит неподвижно).��5�  0   5�     5�     5�     �� 5�     $��20 70 20 10q�6    $
 Left=�65   $B��<Постановка задачи моделирования��6J   #���  6q   �� 5�     -�   5        $ modelingGoalCard��5�     $��10q�67   $ 10��6C   #���  6U   ._�5�     �� .+�5�     �� -�   5        $ modelingGoalText��5�  (   $��40q�6B   $
��Wrap=�6N   $ Justify=�6b   $
��Left=�6z   $  25��6�   #���  6�   $����Задачей моделирования является определение попадания баскетбольного мяча заданного типа (массы m и радиуса r), брошенного под углом α к оси Z и углом β к оси X с начальной высоты h_0 и расстояния x_0 и y_0 от границ площадки в кольцо с известными координатами (зависящими от выбора кольца для броска). Помимо выявления самого факта попадания мяча, происходит вычисление максимальной высоты, времени и дальности полета, а также определяется его положение в любой момент времени.��5�  0   5�     5�     �� 5�     $��20 70 20 10q�6    $
 Left=�65   $A��;Возмущения и ограничения модели��6J   #���  6q   �� 5�     -�   5        $ modelingPerturbationsCard��5�     $��10q�6@   $ 10��6L   #���  6^   ._�5�     �� .+�5�     �� -�   5        $ modelingPerturbationsText��5�  (   $��40 40 40 10q�6K   $
��Wrap=�6`   $ Justify=�6t   $
��Left=�6�   $  25��6�   #���  6�   $����При описании полета баскетбольного мяча, определяемого как материальную точку (его механическую модель), были приняты следующие предположения и ограничения:��5�  0   �� 5�     -�   5        $  modelingPerturbationsText2��5�  (   $��100 0 100 40q�6L   $
��Wrap=�6b   $ Justify=�6v   $
��Left=�6�   $  30��6�   #���  6�   $����
• бросок осуществляется без «подкручивания» (отсутствует влияние силы Магнуса);                                        
• попаданием считается только «чистое» попадание в кольцо – без отскоков от щита;                                        
• бросок осуществляется в помещении, исключающем порывы ветра;                                        
• отсутствуют внешние физические помехи – толчки, землетрясения;                                        
• погрешность определения начальных данных (начальной скорости мяча, угла броска, а также расстояния и высоты) ничтожно мала;                                        
• мяч перемещается строго в одной плоскости (то есть, рассматриваются только две оси – горизонтальная X и вертикальная Y);                                        
• изменение плотности воздуха с изменением высоты настолько мало, что не учитывается;                                        
• координате материальной точки соответствует координата центра механической модели баскетбольного мяча.��5�  0   5�     5�     5�     5�     5�     5�     5�     