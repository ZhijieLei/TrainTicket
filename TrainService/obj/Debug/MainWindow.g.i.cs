﻿#pragma checksum "..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "370E01990F5FFBDFDDFD176962F394DB1F083049"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Animation;
using Telerik.Windows.Controls.Behaviors;
using Telerik.Windows.Controls.Carousel;
using Telerik.Windows.Controls.Docking;
using Telerik.Windows.Controls.DragDrop;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Controls.LayoutControl;
using Telerik.Windows.Controls.Legend;
using Telerik.Windows.Controls.Primitives;
using Telerik.Windows.Controls.RadialMenu;
using Telerik.Windows.Controls.RibbonView;
using Telerik.Windows.Controls.TransitionEffects;
using Telerik.Windows.Controls.TreeListView;
using Telerik.Windows.Controls.TreeView;
using Telerik.Windows.Controls.Wizard;
using Telerik.Windows.Data;
using Telerik.Windows.DragDrop;
using Telerik.Windows.DragDrop.Behaviors;
using Telerik.Windows.Input.Touch;
using Telerik.Windows.Shapes;
using TrainService;
using TrainService.Converters;
using TrainService.Converters.Ui;


namespace TrainService {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : Telerik.Windows.Controls.RadRibbonWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadAutoCompleteBox FromStationInput;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadAutoCompleteBox ToStationInput;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadDatePicker DepartureDateInput;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel FilterTypePanel;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterG;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterD;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterZ;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterT;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterK;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterN;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel FilterSeatPanel;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterSw;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterZy;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterZe;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterDw;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterGr;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterRw;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterYw;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterRz;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterYz;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox FilterWz;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Telerik.Windows.Controls.RadGridView QueryResults;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TrainService;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FromStationInput = ((Telerik.Windows.Controls.RadAutoCompleteBox)(target));
            return;
            case 2:
            this.ToStationInput = ((Telerik.Windows.Controls.RadAutoCompleteBox)(target));
            return;
            case 3:
            this.DepartureDateInput = ((Telerik.Windows.Controls.RadDatePicker)(target));
            return;
            case 4:
            
            #line 58 "..\..\MainWindow.xaml"
            ((Telerik.Windows.Controls.RadRibbonButton)(target)).Click += new System.Windows.RoutedEventHandler(this.NormalQuery);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilterTypePanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.FilterG = ((System.Windows.Controls.CheckBox)(target));
            
            #line 65 "..\..\MainWindow.xaml"
            this.FilterG.Click += new System.Windows.RoutedEventHandler(this.FilterTypeClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FilterD = ((System.Windows.Controls.CheckBox)(target));
            
            #line 67 "..\..\MainWindow.xaml"
            this.FilterD.Click += new System.Windows.RoutedEventHandler(this.FilterTypeClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.FilterZ = ((System.Windows.Controls.CheckBox)(target));
            
            #line 69 "..\..\MainWindow.xaml"
            this.FilterZ.Click += new System.Windows.RoutedEventHandler(this.FilterTypeClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.FilterT = ((System.Windows.Controls.CheckBox)(target));
            
            #line 71 "..\..\MainWindow.xaml"
            this.FilterT.Click += new System.Windows.RoutedEventHandler(this.FilterTypeClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FilterK = ((System.Windows.Controls.CheckBox)(target));
            
            #line 73 "..\..\MainWindow.xaml"
            this.FilterK.Click += new System.Windows.RoutedEventHandler(this.FilterTypeClick);
            
            #line default
            #line hidden
            return;
            case 11:
            this.FilterN = ((System.Windows.Controls.CheckBox)(target));
            
            #line 75 "..\..\MainWindow.xaml"
            this.FilterN.Click += new System.Windows.RoutedEventHandler(this.FilterTypeClick);
            
            #line default
            #line hidden
            return;
            case 12:
            this.FilterSeatPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 13:
            this.FilterSw = ((System.Windows.Controls.CheckBox)(target));
            
            #line 82 "..\..\MainWindow.xaml"
            this.FilterSw.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 14:
            this.FilterZy = ((System.Windows.Controls.CheckBox)(target));
            
            #line 84 "..\..\MainWindow.xaml"
            this.FilterZy.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 15:
            this.FilterZe = ((System.Windows.Controls.CheckBox)(target));
            
            #line 86 "..\..\MainWindow.xaml"
            this.FilterZe.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 16:
            this.FilterDw = ((System.Windows.Controls.CheckBox)(target));
            
            #line 88 "..\..\MainWindow.xaml"
            this.FilterDw.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 17:
            this.FilterGr = ((System.Windows.Controls.CheckBox)(target));
            
            #line 92 "..\..\MainWindow.xaml"
            this.FilterGr.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 18:
            this.FilterRw = ((System.Windows.Controls.CheckBox)(target));
            
            #line 94 "..\..\MainWindow.xaml"
            this.FilterRw.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 19:
            this.FilterYw = ((System.Windows.Controls.CheckBox)(target));
            
            #line 96 "..\..\MainWindow.xaml"
            this.FilterYw.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 20:
            this.FilterRz = ((System.Windows.Controls.CheckBox)(target));
            
            #line 98 "..\..\MainWindow.xaml"
            this.FilterRz.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 21:
            this.FilterYz = ((System.Windows.Controls.CheckBox)(target));
            
            #line 100 "..\..\MainWindow.xaml"
            this.FilterYz.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 22:
            this.FilterWz = ((System.Windows.Controls.CheckBox)(target));
            
            #line 102 "..\..\MainWindow.xaml"
            this.FilterWz.Click += new System.Windows.RoutedEventHandler(this.FilterSeatClick);
            
            #line default
            #line hidden
            return;
            case 23:
            this.QueryResults = ((Telerik.Windows.Controls.RadGridView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

