﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aurora.Devices.Razer
{
    public static class RazerLayoutMap
    {
        public static readonly Dictionary<DeviceKeys, int[]> GenericKeyboard = new Dictionary<DeviceKeys, int[]>
        {
            {DeviceKeys.ESC, new int [] {0,1} },
            {DeviceKeys.F1, new int [] {0, 3} },
            {DeviceKeys.F2, new int [] {0, 4} },
            {DeviceKeys.F3, new int [] {0, 5} },
            {DeviceKeys.F4, new int [] {0, 6} },
            {DeviceKeys.F5, new int [] {0, 7} },
            {DeviceKeys.F6, new int [] {0, 8} },
            {DeviceKeys.F7, new int [] {0, 9} },
            {DeviceKeys.F8, new int [] {0, 10} },
            {DeviceKeys.F9, new int [] {0, 11} },
            {DeviceKeys.F10, new int [] {0, 12} },
            {DeviceKeys.F11, new int [] {0, 13} },
            {DeviceKeys.F12, new int [] {0, 14} },
            {DeviceKeys.PRINT_SCREEN, new int [] {0, 15} },
            {DeviceKeys.SCROLL_LOCK, new int [] {0, 16} },
            {DeviceKeys.PAUSE_BREAK, new int [] {0, 17} },
            {DeviceKeys.LOGO, new int [] {0, 20 } },
            {DeviceKeys.G1, new int [] {1, 0} },
            {DeviceKeys.TILDE, new int [] {1, 1} },
            {DeviceKeys.ONE, new int [] {1, 2} },
            {DeviceKeys.TWO, new int [] {1, 3} },
            {DeviceKeys.THREE, new int [] {1, 4} },
            {DeviceKeys.FOUR, new int [] {1, 5} },
            {DeviceKeys.FIVE, new int [] {1, 6} },
            {DeviceKeys.SIX, new int [] {1, 7} },
            {DeviceKeys.SEVEN, new int [] {1, 8} },
            {DeviceKeys.EIGHT, new int [] {1, 9} },
            {DeviceKeys.NINE, new int [] {1, 10} },
            {DeviceKeys.ZERO, new int [] {1, 11} },
            {DeviceKeys.MINUS, new int [] {1, 12} },
            {DeviceKeys.EQUALS, new int [] {1, 13} },
            {DeviceKeys.BACKSPACE, new int [] {1, 14} },
            {DeviceKeys.INSERT, new int [] {1, 15} },
            {DeviceKeys.HOME, new int [] {1, 16} },
            {DeviceKeys.PAGE_UP, new int [] {1, 17} },
            {DeviceKeys.NUM_LOCK, new int [] {1, 18} },
            {DeviceKeys.NUM_SLASH, new int [] {1, 19} },
            {DeviceKeys.NUM_ASTERISK, new int [] {1, 20} },
            {DeviceKeys.NUM_MINUS, new int [] {1, 21} },
            {DeviceKeys.G2, new int [] {2, 0} },
            {DeviceKeys.TAB, new int [] {2, 1} },
            {DeviceKeys.Q, new int [] {2, 2} },
            {DeviceKeys.W, new int [] {2, 3} },
            {DeviceKeys.E, new int [] {2, 4} },
            {DeviceKeys.R, new int [] {2, 5} },
            {DeviceKeys.T, new int [] {2, 6} },
            {DeviceKeys.Y, new int [] {2, 7} },
            {DeviceKeys.U, new int [] {2, 8} },
            {DeviceKeys.I, new int [] {2, 9} },
            {DeviceKeys.O, new int [] {2, 10} },
            {DeviceKeys.P, new int [] {2, 11} },
            {DeviceKeys.OPEN_BRACKET, new int [] {2, 12} },
            {DeviceKeys.CLOSE_BRACKET, new int [] {2,13} },
            {DeviceKeys.BACKSLASH, new int [] {2, 14} },
            {DeviceKeys.DELETE, new int [] {2, 15} },
            {DeviceKeys.END, new int [] {2, 16} },
            {DeviceKeys.PAGE_DOWN, new int [] {2, 17} },
            {DeviceKeys.NUM_SEVEN, new int [] {2, 18} },
            {DeviceKeys.NUM_EIGHT, new int [] {2, 19} },
            {DeviceKeys.NUM_NINE, new int [] {2, 20} },
            {DeviceKeys.NUM_PLUS, new int [] {2, 21} },
            {DeviceKeys.G3, new int [] {3, 0} },
            {DeviceKeys.CAPS_LOCK, new int [] {3, 1} },
            {DeviceKeys.A, new int [] {3, 2} },
            {DeviceKeys.S, new int [] {3, 3} },
            {DeviceKeys.D, new int [] {3, 4} },
            {DeviceKeys.F, new int [] {3, 5} },
            {DeviceKeys.G, new int [] {3, 6} },
            {DeviceKeys.H, new int [] {3, 7} },
            {DeviceKeys.J, new int [] {3, 8} },
            {DeviceKeys.K, new int [] {3, 9} },
            {DeviceKeys.L, new int [] {3, 10} },
            {DeviceKeys.SEMICOLON, new int [] {3, 11} },
            {DeviceKeys.APOSTROPHE, new int [] {3, 12} },
            {DeviceKeys.HASHTAG, new int [] {3, 13} },
            {DeviceKeys.ENTER, new int [] {3, 14} },
            {DeviceKeys.NUM_FOUR, new int [] {3, 18} },
            {DeviceKeys.NUM_FIVE, new int [] {3, 19} },
            {DeviceKeys.NUM_SIX, new int [] {3, 20} },
            {DeviceKeys.G4, new int [] {4, 0} },
            {DeviceKeys.LEFT_SHIFT, new int [] {4, 1} },
            {DeviceKeys.BACKSLASH_UK, new int [] {4, 2} },
            {DeviceKeys.Z, new int [] {4, 3} },
            {DeviceKeys.X, new int [] {4, 4} },
            {DeviceKeys.C, new int [] {4, 5} },
            {DeviceKeys.V, new int [] {4, 6} },
            {DeviceKeys.B, new int [] {4, 7} },
            {DeviceKeys.N, new int [] {4, 8} },
            {DeviceKeys.M, new int [] {4, 9} },
            {DeviceKeys.COMMA, new int [] {4, 10} },
            {DeviceKeys.PERIOD, new int [] {4, 11} },
            {DeviceKeys.FORWARD_SLASH, new int [] {4, 12} },
            {DeviceKeys.RIGHT_SHIFT, new int [] {4, 14} },
            {DeviceKeys.ARROW_UP, new int [] {4, 16} },
            {DeviceKeys.NUM_ONE, new int [] {4, 18} },
            {DeviceKeys.NUM_TWO, new int [] {4, 19} },
            {DeviceKeys.NUM_THREE, new int [] {4, 20} },
            {DeviceKeys.NUM_ENTER, new int [] {4, 21} },
            {DeviceKeys.G5, new int [] {5, 0} },
            {DeviceKeys.LEFT_CONTROL, new int [] {5, 1} },
            {DeviceKeys.LEFT_WINDOWS, new int [] {5, 2} },
            {DeviceKeys.LEFT_ALT, new int [] {5, 3} },
            {DeviceKeys.SPACE, new int [] {5, 7} },
            {DeviceKeys.RIGHT_ALT, new int [] {5, 11} },
            {DeviceKeys.RIGHT_WINDOWS, new int [] {5, 12} },
            {DeviceKeys.FN_Key, new int [] {5, 12} },
            {DeviceKeys.APPLICATION_SELECT, new int [] {5, 13} },
            {DeviceKeys.RIGHT_CONTROL, new int [] {5, 14} },
            {DeviceKeys.ARROW_LEFT, new int [] {5, 15} },
            //{DeviceKeys.ARROW_DOWN, new int [] {5, 16} },
            {DeviceKeys.ARROW_RIGHT, new int [] {5, 17} },
            {DeviceKeys.NUM_ZERO, new int [] {5, 19} },
            {DeviceKeys.NUM_PERIOD, new int [] {5, 20} }
        };

        public static readonly Dictionary<DeviceKeys, int[]> Blade = new Dictionary<DeviceKeys, int[]>
        {
            {DeviceKeys.ESC, new int [] {0,1} },
            {DeviceKeys.F1, new int [] {0, 3} },
            {DeviceKeys.F2, new int [] {0, 4} },
            {DeviceKeys.F3, new int [] {0, 5} },
            {DeviceKeys.F4, new int [] {0, 6} },
            {DeviceKeys.F5, new int [] {0, 7} },
            {DeviceKeys.F6, new int [] {0, 8} },
            {DeviceKeys.F7, new int [] {0, 9} },
            {DeviceKeys.F8, new int [] {0, 10} },
            {DeviceKeys.F9, new int [] {0, 11} },
            {DeviceKeys.F10, new int [] {0, 12} },
            {DeviceKeys.F11, new int [] {0, 13} },
            {DeviceKeys.F12, new int [] {0, 14} },
            {DeviceKeys.INSERT, new int [] {1, 15} },
            {DeviceKeys.DELETE, new int [] {2, 15} },
            {DeviceKeys.TILDE, new int [] {1, 1} },
            {DeviceKeys.ONE, new int [] {1, 2} },
            {DeviceKeys.TWO, new int [] {1, 3} },
            {DeviceKeys.THREE, new int [] {1, 4} },
            {DeviceKeys.FOUR, new int [] {1, 5} },
            {DeviceKeys.FIVE, new int [] {1, 6} },
            {DeviceKeys.SIX, new int [] {1, 7} },
            {DeviceKeys.SEVEN, new int [] {1, 8} },
            {DeviceKeys.EIGHT, new int [] {1, 9} },
            {DeviceKeys.NINE, new int [] {1, 10} },
            {DeviceKeys.ZERO, new int [] {1, 11} },
            {DeviceKeys.MINUS, new int [] {1, 12} },
            {DeviceKeys.EQUALS, new int [] {1, 13} },
            {DeviceKeys.BACKSPACE, new int [] {1, 14} },
            {DeviceKeys.TAB, new int [] {2, 1} },
            {DeviceKeys.Q, new int [] {2, 2} },
            {DeviceKeys.W, new int [] {2, 3} },
            {DeviceKeys.E, new int [] {2, 4} },
            {DeviceKeys.R, new int [] {2, 5} },
            {DeviceKeys.T, new int [] {2, 6} },
            {DeviceKeys.Y, new int [] {2, 7} },
            {DeviceKeys.U, new int [] {2, 8} },
            {DeviceKeys.I, new int [] {2, 9} },
            {DeviceKeys.O, new int [] {2, 10} },
            {DeviceKeys.P, new int [] {2, 11} },
            {DeviceKeys.OPEN_BRACKET, new int [] {2, 12} },
            {DeviceKeys.CLOSE_BRACKET, new int [] {2,13} },
            {DeviceKeys.BACKSLASH, new int [] {2, 14} },
            {DeviceKeys.BACKSLASH_UK, new int [] {2, 14} },
            {DeviceKeys.CAPS_LOCK, new int [] {3, 1} },
            {DeviceKeys.A, new int [] {3, 2} },
            {DeviceKeys.S, new int [] {3, 3} },
            {DeviceKeys.D, new int [] {3, 4} },
            {DeviceKeys.F, new int [] {3, 5} },
            {DeviceKeys.G, new int [] {3, 6} },
            {DeviceKeys.H, new int [] {3, 7} },
            {DeviceKeys.J, new int [] {3, 8} },
            {DeviceKeys.K, new int [] {3, 9} },
            {DeviceKeys.L, new int [] {3, 10} },
            {DeviceKeys.SEMICOLON, new int [] {3, 11} },
            {DeviceKeys.APOSTROPHE, new int [] {3, 12} },
            {DeviceKeys.ENTER, new int [] {3, 14} },
            {DeviceKeys.LEFT_SHIFT, new int [] {4, 1} },
            {DeviceKeys.Z, new int [] {4, 3} },
            {DeviceKeys.X, new int [] {4, 4} },
            {DeviceKeys.C, new int [] {4, 5} },
            {DeviceKeys.V, new int [] {4, 6} },
            {DeviceKeys.B, new int [] {4, 7} },
            {DeviceKeys.N, new int [] {4, 8} },
            {DeviceKeys.M, new int [] {4, 9} },
            {DeviceKeys.COMMA, new int [] {4, 10} },
            {DeviceKeys.PERIOD, new int [] {4, 11} },
            {DeviceKeys.FORWARD_SLASH, new int [] {4, 12} },
            {DeviceKeys.RIGHT_SHIFT, new int [] {4, 14} },
            {DeviceKeys.LEFT_CONTROL, new int [] {5, 1} },
            {DeviceKeys.LEFT_FN, new int [] {5, 12} },
            {DeviceKeys.LEFT_WINDOWS, new int [] {5, 2} },
            {DeviceKeys.LEFT_ALT, new int [] {5, 3} },
            {DeviceKeys.RIGHT_ALT, new int [] {5, 9} },
            {DeviceKeys.FN_Key, new int [] {5, 12} },
            {DeviceKeys.RIGHT_CONTROL, new int [] {5, 14} },
            {DeviceKeys.ARROW_LEFT, new int [] {5, 15} },
            {DeviceKeys.ARROW_UP, new int [] {4, 16} },
            {DeviceKeys.ARROW_DOWN, new int [] {5, 16} },
            {DeviceKeys.ARROW_RIGHT, new int [] {5, 17} }
        };
    }
}
