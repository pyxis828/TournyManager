   M S B A M L   `   `   `  ����B  >Tourny2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Tourny2Tourny2  5   	       Tourny2.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Tourny2     5   	     � Title$  Structure Entry��5   	   $
��2000��6!   $	��850��6/   $��Verdana)�6;   $��16(�6P    � 
ResizeMode$ CanMinimize=�6^   .��5	      � $��0,0,0,0q�6   }�. .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5
         CanUserAddRows .    HeadersVisibility$ Column=�6;      AutoGenerateColumns .  ���	#FFCEE8E5$��Center=�6�   $��Center=�6�      CanUserSortColumns .     CanUserReorderColumns .     FrozenColumnCount$ 1��6  }�. 	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Levels��6*      ClipboardContentBinding 6:   �� *	LevelName+   CellTemplate 5      �� 5      .R�5      ��  ��Name$ 
levelEntry��6&   $
��Auto��6;   ��6I   �� *	LevelName+5      5        5      $
 	Use Antes��6)    6<   �� *
UseAntes+ 5      �� 5      .R�5      ��  ��Name$ useAntes��6'   -   5        $��Right=�5   9   $��Bottom=�6U   $��0,0,5,6q�6p    d� 	IsChecked 6�   �� *
IsActive+6�   5      5        5      -   5        
EnterAntes��$
 Antes��5   =    6L   �� *Antes+ 5      �� 5      .R�5      �� $ 
antesEntry��6&   -   5        $
��Auto��5   :   {�.  ��6v   �� *Antes+ �� TargetNullValue$  ��6�   5      5         5!      $
 Small Blind��6)    6>   �� *
SmallBlind+ 5"      �� 5#      .R�5$      �� $ SBEntry��6&   -   5        $
��Auto��5$   7   ��6^   �� *
SmallBlind+5%      5'        5(      $
 	Big Blind��6)    6<   �� *
BigBlind+ 5)      �� 5*      .R�5+      �� $ BBEntry��6&   -   5        $
��Auto��5+   7   ��6^   �� *
BigBlind+5,      5.        5/      $
 
Level Time��6)    6=   �� *	LevelTime+ 50      �� 51      .R�52      �� $ levelTimeEntry��6&   -   5        $
��Auto��52   >   ��6h   �� *	LevelTime+53      55        56      $
 
List Games��6)    6=   �� *	ListGames+ 57      �� 58      .R�59      �� $ 	listGames��6'   -   5        $��Right=�59   :   $��Bottom=�6V   $��0,0,5,6q�6q    6�   �� *
IsActive+6�   5:      5<        5=      $
 Current Game��6)    6?   �� *CurrentGame+ 5>      �� 5?      .R�5@      �� $ 	gameEntry��6&   -	   5        $
��Auto��5@   9   {�.  ��6Z   �� *CurrentGame+$  ��6�   5A      5C      5E      �� 5F   
   -
   5         ��Name$ SaveStructure��5F      $
��Save��6(   $��Verdana)�67   $
��Left=�6L   $��	739,0,0,0q�6g   $��Bottom=�6z   $��95��6�   $��27��6�   }�. 6�   �� 5G   
   -   5        $ LoadStructure��5G      $
��Load��6(   $��Verdana)�67   $
��Left=�6L   $��739,0,0,206q�6g   $��Bottom=�6|   $��95��6�   $��27��6�   }�. 6�   �� 5H   
   -   5        $ AddLevel��5H      $��	Add Level��6#   $��Verdana)�67   $
��Left=�6M   $��739,0,0,177q�6h   $��Bottom=�6}   $��95��6�   $��27��6�   }�. 6�   �� 5I   
   -   5        $ AddBreak��5I      $��	Add Break��6#   $��Verdana)�67   $
��Left=�6M   $��739,0,0,148q�6h   $��Bottom=�6}   $��95��6�   $��27��6�   }�. 6�   5J      5K      