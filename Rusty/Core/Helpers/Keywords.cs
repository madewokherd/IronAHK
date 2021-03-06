﻿
namespace IronAHK.Rusty
{
    partial class Core
    {
        public static readonly char[] Keyword_Spaces = { '\r', '\n', ' ', '\t', '\xA0' };
        public const string Keyword_Linefeed = "\r\n";

        public const string Keyword_Pixel = "pixel";
        public const string Keyword_Mouse = "mouse";
        public const string Keyword_Screen = "screen";
        public const string Keyword_Relative = "relative";
        public const string Keyword_RGB = "rgb";
        public const string Keyword_LTrim = "ltrim";
        public const string Keyword_RTrim = "rtrim";
        public const string Keyword_Join = "join";
        public const string Keyword_Low = "low";
        public const string Keyword_BelowNormal = "belownormal";
        public const string Keyword_Normal = "normal";
        public const string Keyword_AboveNormal = "abovenormal";
        public const string Keyword_High = "high";
        public const string Keyword_Realtime = "realtime";
        public const string Keyword_ahk_id = "ahk_id";
        public const string Keyword_ahk_pid = "ahk_pid";
        public const string Keyword_ahk_class = "ahk_class";
        public const string Keyword_ahk_group = "ahk_group";
        public const string Keyword_Between = "between";
        public const string Keyword_Contains = "contains";
        public const string Keyword_In = "in";
        public const string Keyword_Is = "is";
        public const string Keyword_Integer = "integer";
        public const string Keyword_Float = "float";
        public const string Keyword_Number = "number";
        public const string Keyword_Digit = "digit";
        public const string Keyword_XDigit = "xdigit";
        public const string Keyword_Alpha = "alpha";
        public const string Keyword_Upper = "upper";
        public const string Keyword_Lower = "lower";
        public const string Keyword_Alnum = "alnum";
        public const string Keyword_Time = "time";
        public const string Keyword_Date = "date";
        public const string Keyword_Not = "not";
        public const string Keyword_Or = "or";
        public const string Keyword_And = "and";
        public const string Keyword_AlwaysOnTop = "alwaysontop";
        public const string Keyword_Topmost = "topmost";
        public const string Keyword_Top = "top";
        public const string Keyword_Bottom = "bottom";
        public const string Keyword_Transparent = "transparent";
        public const string Keyword_Transcolor = "transcolor";
        public const string Keyword_Redraw = "redraw";
        public const string Keyword_Region = "region";
        public const string Keyword_ID = "id";
        public const string Keyword_IDLast = "idlast";
        public const string Keyword_ProcessName = "processname";
        public const string Keyword_MinMax = "minmax";
        public const string Keyword_ControlList = "controllist";
        public const string Keyword_Count = "count";
        public const string Keyword_List = "list";
        public const string Keyword_Capacity = "capacity";
        public const string Keyword_StatusCD = "statuscd";
        public const string Keyword_Eject = "eject";
        public const string Keyword_Lock = "lock";
        public const string Keyword_Unlock = "unlock";
        public const string Keyword_Label = "label";
        public const string Keyword_FileSystem = "filesystem";
        public const string Keyword_SetLabel = "setlabel";
        public const string Keyword_Serial = "serial";
        public const string Keyword_Type = "type";
        public const string Keyword_Status = "status";
        public const string Keyword_Static = "static";
        public const string Keyword_Global = "global";
        public const string Keyword_Local = "local";
        public const string Keyword_ByRef = "byref";
        public const string Keyword_Seconds = "seconds";
        public const string Keyword_Minutes = "minutes";
        public const string Keyword_Hours = "hours";
        public const string Keyword_Days = "days";
        public const string Keyword_Read = "read";
        public const string Keyword_Parse = "parse";
        public const string Keyword_Logoff = "logoff";
        public const string Keyword_Close = "close";
        public const string Keyword_Error = "error";
        public const string Keyword_Single = "single";
        public const string Keyword_Tray = "tray";
        public const string Keyword_Add = "add";
        public const string Keyword_Rename = "rename";
        public const string Keyword_Check = "check";
        public const string Keyword_Uncheck = "uncheck";
        public const string Keyword_ToggleCheck = "togglecheck";
        public const string Keyword_Enable = "enable";
        public const string Keyword_Disable = "disable";
        public const string Keyword_ToggleEnable = "toggleenable";
        public const string Keyword_Default = "default";
        public const string Keyword_NoDefault = "nodefault";
        public const string Keyword_Standard = "standard";
        public const string Keyword_NoStandard = "nostandard";
        public const string Keyword_Color = "color";
        public const string Keyword_Delete = "delete";
        public const string Keyword_DeleteAll = "deleteall";
        public const string Keyword_Icon = "icon";
        public const string Keyword_NoIcon = "noicon";
        public const string Keyword_Tip = "tip";
        public const string Keyword_Click = "click";
        public const string Keyword_Show = "show";
        public const string Keyword_MainWindow = "mainwindow";
        public const string Keyword_NoMainWindow = "nomainwindow";
        public const string Keyword_UseErrorLevel = "useerrorlevel";
        public const string Keyword_Text = "text";
        public const string Keyword_Picture = "picture";
        public const string Keyword_Pic = "pic";
        public const string Keyword_GroupBox = "groupbox";
        public const string Keyword_Button = "button";
        public const string Keyword_CheckBox = "checkbox";
        public const string Keyword_Radio = "radio";
        public const string Keyword_DropDownList = "dropdownlist";
        public const string Keyword_DDL = "ddl";
        public const string Keyword_ComboBox = "combobox";
        public const string Keyword_ListBox = "listbox";
        public const string Keyword_ListView = "listview";
        public const string Keyword_DateTime = "datetime";
        public const string Keyword_MonthCal = "monthcal";
        public const string Keyword_Slider = "slider";
        public const string Keyword_StatusBar = "statusbar";
        public const string Keyword_Tab = "tab";
        public const string Keyword_Tab2 = "tab2";
        public const string Keyword_TreeView = "treeview";
        public const string Keyword_UpDown = "updown";
        public const string Keyword_IconSmall = "iconsmall";
        public const string Keyword_Tile = "tile";
        public const string Keyword_Report = "report";
        public const string Keyword_SortDesc = "sortdesc";
        public const string Keyword_NoSort = "nosort";
        public const string Keyword_NoSortHdr = "nosorthdr";
        public const string Keyword_Grid = "grid";
        public const string Keyword_Hdr = "hdr";
        public const string Keyword_AutoSize = "autosize";
        public const string Keyword_Range = "range";
        public const string Keyword_xm = "xm";
        public const string Keyword_ym = "ym";
        public const string Keyword_ys = "ys";
        public const string Keyword_xs = "xs";
        public const string Keyword_xp = "xp";
        public const string Keyword_yp = "yp";
        public const string Keyword_Font = "font";
        public const string Keyword_Resize = "resize";
        public const string Keyword_Owner = "owner";
        public const string Keyword_Submit = "submit";
        public const string Keyword_NoHide = "nohide";
        public const string Keyword_Minimize = "minimize";
        public const string Keyword_Maximize = "maximize";
        public const string Keyword_Restore = "restore";
        public const string Keyword_NoActivate = "noactivate";
        public const string Keyword_NA = "na";
        public const string Keyword_Cancel = "cancel";
        public const string Keyword_Destroy = "destroy";
        public const string Keyword_Center = "center";
        public const string Keyword_Margin = "margin";
        public const string Keyword_MaxSize = "maxsize";
        public const string Keyword_MinSize = "minsize";
        public const string Keyword_OwnDialogs = "owndialogs";
        public const string Keyword_GuiEscape = "escape";
        public const string Keyword_GuiClose = "close";
        public const string Keyword_GuiSize = "size";
        public const string Keyword_GuiContextMenu = "contextmenu";
        public const string Keyword_GuiDropFiles = "dropfiles";
        public const string Keyword_TabStop = "tabstop";
        public const string Keyword_Section = "section";
        public const string Keyword_AltSubmit = "altsubmit";
        public const string Keyword_Wrap = "wrap";
        public const string Keyword_HScroll = "hscroll";
        public const string Keyword_VScroll = "vscroll";
        public const string Keyword_Border = "border";
        public const string Keyword_Buttons = "buttons";
        public const string Keyword_Expand = "expand";
        public const string Keyword_First = "first";
        public const string Keyword_ImageList = "imagelist";
        public const string Keyword_Lines = "lines";
        public const string Keyword_WantCtrlA = "wantctrla";
        public const string Keyword_WantF2 = "wantf2";
        public const string Keyword_Vis = "vis";
        public const string Keyword_VisFirst = "visfirst";
        public const string Keyword_Uppercase = "uppercase";
        public const string Keyword_Lowercase = "lowercase";
        public const string Keyword_Limit = "limit";
        public const string Keyword_Password = "password";
        public const string Keyword_Multi = "multi";
        public const string Keyword_WantReturn = "wantreturn";
        public const string Keyword_Group = "group";
        public const string Keyword_Background = "background";
        public const string Keyword_Bold = "bold";
        public const string Keyword_Italic = "italic";
        public const string Keyword_Strike = "strike";
        public const string Keyword_Underline = "underline";
        public const string Keyword_Norm = "norm";
        public const string Keyword_BackgroundTrans = "backgroundtrans";
        public const string Keyword_Theme = "theme";
        public const string Keyword_Caption = "caption";
        public const string Keyword_Delimiter = "delimiter";
        public const string Keyword_MinimizeBox = "minimizebox";
        public const string Keyword_MaximizeBox = "maximizebox";
        public const string Keyword_SysMenu = "sysmenu";
        public const string Keyword_ToolWindow = "toolwindow";
        public const string Keyword_Flash = "flash";
        public const string Keyword_Style = "style";
        public const string Keyword_ExStyle = "exstyle";
        public const string Keyword_Check3 = "check3";
        public const string Keyword_Checked = "checked";
        public const string Keyword_CheckedGray = "checkedgray";
        public const string Keyword_Readonly = "readonly";
        public const string Keyword_Hidden = "hidden";
        public const string Keyword_Left = "left";
        public const string Keyword_Right = "right";
        public const string Keyword_NoTab = "notab";
        public const string Keyword_Move = "move";
        public const string Keyword_Focus = "focus";
        public const string Keyword_Hide = "hide";
        public const string Keyword_Choose = "choose";
        public const string Keyword_ChooseString = "choosestring";
        public const string Keyword_Pos = "pos";
        public const string Keyword_Enabled = "enabled";
        public const string Keyword_Disabled = "disabled";
        public const string Keyword_Visible = "visible";
        public const string Keyword_LastFound = "lastfound";
        public const string Keyword_LastFoundExist = "lastfoundexist";
        public const string Keyword_AltTab = "alttab";
        public const string Keyword_ShiftAltAab = "shiftalttab";
        public const string Keyword_AltTabmenu = "alttabmenu";
        public const string Keyword_AltTabAndMenu = "alttabandmenu";
        public const string Keyword_AltTabMenuDismiss = "alttabmenudismiss";
        public const string Keyword_NoTimers = "notimers";
        public const string Keyword_Interrupt = "interrupt";
        public const string Keyword_Priority = "priority";
        public const string Keyword_WaitClose = "waitclose";
        public const string Keyword_Wait = "wait";
        public const string Keyword_Exist = "exist";
        public const string Keyword_Unicode = "unicode";
        public const string Keyword_Asc = "asc";
        public const string Keyword_Chr = "chr";
        public const string Keyword_Deref = "deref";
        public const string Keyword_Mod = "mod";
        public const string Keyword_Pow = "pow";
        public const string Keyword_Exp = "exp";
        public const string Keyword_Sqrt = "sqrt";
        public const string Keyword_Log = "log";
        public const string Keyword_Ln = "ln";
        public const string Keyword_Round = "round";
        public const string Keyword_Ceil = "ceil";
        public const string Keyword_Floor = "floor";
        public const string Keyword_Abs = "abs";
        public const string Keyword_Sin = "sin";
        public const string Keyword_Cos = "cos";
        public const string Keyword_Tan = "tan";
        public const string Keyword_Asin = "asin";
        public const string Keyword_Acos = "acos";
        public const string Keyword_Atan = "atan";
        public const string Keyword_BitNot = "bitnot";
        public const string Keyword_BitAnd = "bitand";
        public const string Keyword_BitOr = "bitor";
        public const string Keyword_BitXor = "bitxor";
        public const string Keyword_BitShiftLeft = "bitshiftleft";
        public const string Keyword_BitShiftRight = "bitshiftright";
        public const string Keyword_Yes = "yes";
        public const string Keyword_No = "no";
        public const string Keyword_Ok = "ok";
        public const string Keyword_Abort = "abort";
        public const string Keyword_Retry = "retry";
        public const string Keyword_Ignore = "ignore";
        public const string Keyword_TryAgain = "tryagain";
        public const string Keyword_On = "on";
        public const string Keyword_Off = "off";
        public const string Keyword_All = "all";
        public const string Keyword_HKey_Local_Machine = "hkey_local_machine";
        public const string Keyword_HKey_Users = "hkey_users";
        public const string Keyword_HKey_Current_User = "hkey_current_user";
        public const string Keyword_HKey_Classes_Root = "hkey_classes_root";
        public const string Keyword_HKey_Current_Config = "hkey_current_config";
        public const string Keyword_HKLM = "hklm";
        public const string Keyword_HKU = "hku";
        public const string Keyword_HKCU = "hkcu";
        public const string Keyword_HKCR = "hkcr";
        public const string Keyword_HKCC = "hkcc";
        public const string Keyword_Reg_Sz = "reg_sz";
        public const string Keyword_Reg_Expand_Sz = "reg_expand_sz";
        public const string Keyword_Reg_Multi_Sz = "reg_multi_sz";
        public const string Keyword_Reg_Dword = "reg_dword";
        public const string Keyword_Reg_Binary = "reg_binary";
        public const string Keyword_Cursor = "cursor";
        public const string Keyword_TaskBar = "taskbar";
        public const string Keyword_BackGroundImage = "backgroundimage";
        public const string Keyword_Zoom = "zoom";
        public const string Keyword_Stretch = "stretch";
 
        public const string Keyword_None = "none";
        public const string Keyword_Selected = "selected";
        public const string Keyword_Select = "select";
        public const string Keyword_Column = "column";
        public const string Keyword_RegEx = "regex";
        public const string Keyword_Fast = "fast";
        public const string Keyword_Slow = "slow";
        public const string Keyword_ToolTip = "tooltip";
        public const string Keyword_Caret = "caret";
        public const string Keyword_Menu = "menu";
        public const string Keyword_Locale = "locale";
        public const string Keyword_CSV = "csv";
        public const string Keyword_Up = "up";
        public const string Keyword_Down = "down";
        public const string Keyword_Toggle = "toggle";
        public const string Keyword_Edit = "edit";
        public const string Keyword_Hotkey = "hotkey";
        public const string Keyword_Progress = "progress";
        public const string Keyword_WebBrowser = "webbrowser";
        public const string Keyword_WantTab = "wanttab";
        public const string Keyword_Smooth = "smooth";
        public const string Keyword_Vertical = "vertical";
        public const string Keyword_ShortDate = "shortdate";
        public const string Keyword_LongDate = "longdate";
        public const string Keyword_YearMonth = "yearmonth";
        public const string Keyword_YDay = "yday";
        public const string Keyword_YDay0 = "yday0";
        public const string Keyword_WDay = "wday";
        public const string Keyword_YWeek = "yweek";
        public const string Keyword_Random = "random";
        public const string Keyword_Sort = "sort";
        public const string Keyword_Simple = "simple";
        public const string Keyword_Invert = "invert";
        public const string Keyword_Line = "line";
        public const string Keyword_NoTicks = "noticks";
        public const string Keyword_Thick = "thick";
        public const string Keyword_Page = "page";
        public const string Keyword_TickInterval = "tickinterval";
        public const string Keyword_Horz = "horz";
        public const string Keyword_MoveDraw = "movedraw";
        public const string Keyword_Hwnd = "hwnd";
        public const string Keyword_GuiPrefix = "gui";
        public const string Keyword_GuiButton = "Button";
        public const string Keyword_Hex = "hex";
        public const string Keyword_FormatHex = "h";
        public const string Keyword_FormatDecimal = "d";
        public const string Keyword_IniSectionOpen = "[";
        public const char Keyword_IniKeyAssign = '=';
        public const string Keyword_Focused = "focused";
        public const string Keyword_Attachments = "attachments";
        public const string Keyword_Bcc = "bcc";
        public const string Keyword_CC = "cc";
        public const string Keyword_From = "from";
        public const string Keyword_ReplyTo = "replyto";
        public const string Keyword_Host = "host";
        public const char Keyword_Port = ':';
        public const string Keyword_ARGB = "argb";
        public const string Keyword_Variation = "variation";
        public const string Keyword_Trans = "trans";
        public const string Keyword_Full = "full";
        public const string Keyword_Auto = "auto";
        public const string Keyword_AutoHdr = "autohdr";
        public const string Keyword_IconRight = "iconright";
        public const string Keyword_Case = "case";
        public const string Keyword_CaseLocale = "caselocale";
        public const string Keyword_Desc = "desc";
        public const string Keyword_Uni = "uni";
        public const string Keyword_Raw = "raw";
        public const string Keyword_A = "a";
        public const string Keyword_R = "r";
        public const string Keyword_Months = "months";
        public const string Keyword_Years = "years";
        public const string Keyword_Max = "max";
        public const string Keyword_Min = "min";
        public const string Keyword_ahk = "ahk_";

        public const char Keyword_ModifierWin = '#';
        public const char Keyword_ModifierAlt = '!';
        public const string Keyword_ModifierAltGr = "<^>!";
        public const char Keyword_ModifierCtrl = '^';
        public const char Keyword_ModifierShift = '+';
        public const char Keyword_ModifierLeftPair = '<';
        public const char Keyword_ModifierRightPair = '>';
        public const char Keyword_HotkeyIgnoreModifiers = '*';
        public const char Keyword_HotkeyPassThrough = '~';
        public const char Keyword_HotkeyCombination = '&';
        public const char Keyword_HotkeyNoRecurse = '$';
        public const char Keyword_KeyNameOpen = '{';
        public const char Keyword_KeyNameClose = '}';
        public const string Keyword_HotkeyVK = "VK";
        public const string Keyword_HotkeySC = "SC";

        public const char Keyword_HotstringAuto = '*';
        public const char Keyword_HotstringNested = '?';
        public const char Keyword_HotstringBackspace = 'B';
        public const char Keyword_HotstringCase = 'C';
        public const char Keyword_HotstringOmitEnding = 'O';
        public const char Keyword_HotstringReset = 'Z';
        public const char Keyword_HotstringOff = '0';

        public const string Keyword_IfWinActive = "ifwinactive";
        public const string Keyword_IfWinNotActive = "ifwinnotactive";
        public const string Keyword_IfWinExist = "ifwinexist";
        public const string Keyword_IfWinNotExit = "ifwinnotexist";

        // Keywords for Drive Info
        public const string Keyword_CDROM = "CDROM";
        public const string Keyword_REMOVABLE = "REMOVABLE";
        public const string Keyword_FIXED = "FIXED";
        public const string Keyword_NETWORK = "NETWORK";
        public const string Keyword_RAMDISK = "RAMDISK";
        public const string Keyword_UNKNOWN = "UNKNOWN";

        //Keywords for Splash/Progress Options

        public const string Keyword_NotAlwaysOnTop = "A";
        public const string Keyword_Borderless = "B";
        public const string Keyword_ProgressStartPos = "P";
        public const string Keyword_ProgressRange = "R";
        public const string Keyword_ShowInTaskbar = "T";
        public const string Keyword_X = "X";
        public const string Keyword_Y = "Y";
        public const string Keyword_W = "W";
        public const string Keyword_H = "H";

        public const string Keyword_Centered = "C"; // Centered
        public const string Keyword_ZH = "ZH";
        public const string Keyword_ZW = "ZW";
        public const string Keyword_ZX = "ZX";
        public const string Keyword_ZY = "ZY";

        //Keywords for Input Command
        public const string Keyword_LimitS = "L";
        public const string Keyword_BackSpaceS = "B";
        public const string Keyword_IgnoreS = "I";
        public const string Keyword_ModifiedS = "M";
        public const string Keyword_TimeOutS = "T";
        public const string Keyword_VisibleS = "V";
        public const string Keyword_FindAnyWhereS = "*";

        public const string Keyword_DownS = "D";


    }
}
