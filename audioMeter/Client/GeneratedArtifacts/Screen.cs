//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
    public sealed partial class NewPacient
        : global::Microsoft.LightSwitch.Framework.Client.ScreenObject<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass>
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private NewPacient() : base("LightSwitchApplication:NewPacient")
        {
            global::LightSwitchApplication.NewPacient.DetailsClass.Initialize(this);
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static NewPacient CreateInstance()
        {
            return new global::LightSwitchApplication.NewPacient(
            );
        }

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_Activated();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_Saving(ref bool handled);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_Saved();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_Closing(ref bool cancel);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void NewPacient_SaveError(global::System.Exception exception, ref bool handled);
     
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.Application Application
        {
            get
            {
                return global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)((global::Microsoft.LightSwitch.Details.Client.IScreenDetails)this.Details).DataWorkspace;
            }
        }
        
        #endregion
 
        partial void PacientProperty_Changed();

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::LightSwitchApplication.Pacient PacientProperty
        {
            get 
            {
                return global::LightSwitchApplication.NewPacient.DetailsClass.GetValue(this, global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties.PacientProperty);
            }
            set
            {
                global::LightSwitchApplication.NewPacient.DetailsClass.SetValue(this, global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties.PacientProperty, value);
            }
        }
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void PacientProperty_Validate(global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder results);
 
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass
            : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.NewPacient.DetailsClass.PropertySet, global::LightSwitchApplication.NewPacient.DetailsClass.CommandSet, global::LightSwitchApplication.NewPacient.DetailsClass.MethodSet>
        {

            static DetailsClass()
            {
                var initializePropertyEntry = global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties.PacientProperty;
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass>.Entry
                __NewPacientEntry = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenDetails<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass>.Entry(
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeInitializeDataWorkspace,
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeSavingEvent,
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeSavedEvent,
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeClosingEvent,
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeCreated,
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeActivated,
                    global::LightSwitchApplication.NewPacient.DetailsClass.__NewPacient_InvokeSaveErrorEvent);
            private static void __NewPacient_InvokeInitializeDataWorkspace(global::LightSwitchApplication.NewPacient s, global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
            {
                s.NewPacient_InitializeDataWorkspace(saveChangesTo);
            }
            private static bool __NewPacient_InvokeSavingEvent(global::LightSwitchApplication.NewPacient s)
            {
                bool handled = false;
                s.NewPacient_Saving(ref handled);
                return handled;
            }
            private static void __NewPacient_InvokeSavedEvent(global::LightSwitchApplication.NewPacient s)
            {
                s.NewPacient_Saved();
            }
            private static bool __NewPacient_InvokeClosingEvent(global::LightSwitchApplication.NewPacient s)
            {
                bool cancel = false;
                s.NewPacient_Closing(ref cancel);
                return cancel;
            }
            private static void __NewPacient_InvokeCreated(global::LightSwitchApplication.NewPacient s)
            {
                s.NewPacient_Created();
            }
            private static void __NewPacient_InvokeActivated(global::LightSwitchApplication.NewPacient s)
            {
                s.NewPacient_Activated();
            }
            private static bool __NewPacient_InvokeSaveErrorEvent(global::LightSwitchApplication.NewPacient s, global::System.Exception ex)
            {
                bool handled = false;
                s.NewPacient_SaveError(ex, ref handled);
                return handled;
            }

            public DetailsClass() : base()
            {
            }

            public new global::LightSwitchApplication.NewPacient.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }

            public new global::LightSwitchApplication.NewPacient.DetailsClass.CommandSet Commands
            {
                get
                {
                    return base.Commands;
                }
            }

            public new global::LightSwitchApplication.NewPacient.DetailsClass.MethodSet Methods
            {
                get
                {
                    return base.Methods;
                }
            }

            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.Pacient>.Data _PacientProperty;

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenPropertySet<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass>
            {

                public global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.Pacient> PacientProperty
                {
                    get
                    {
                        return (global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.Pacient>)base.GetItem(global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties.PacientProperty);
                    }
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class CommandSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenCommandSet<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class MethodSet
                : global::Microsoft.LightSwitch.Details.Framework.Client.ScreenMethodSet<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass>
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class PropertySetProperties
            {

                public static readonly global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.Pacient>.Entry
                    PacientProperty = new global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.Pacient>.Entry(
                        "PacientProperty",
                        false,
                        global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties._PacientProperty_Stub,
                        global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties._PacientProperty_Validate,
                        global::LightSwitchApplication.NewPacient.DetailsClass.PropertySetProperties._PacientProperty_OnValueChanged);
                private static void _PacientProperty_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.NewPacient.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.Client.ScreenLocalProperty<global::LightSwitchApplication.NewPacient, global::LightSwitchApplication.NewPacient.DetailsClass, global::LightSwitchApplication.Pacient>.Data> c, global::LightSwitchApplication.NewPacient.DetailsClass d, object sf)
                {
                    c(d, ref d._PacientProperty, sf);
                }
                private static void _PacientProperty_Validate(global::LightSwitchApplication.NewPacient s, global::Microsoft.LightSwitch.Framework.Client.ScreenValidationResultsBuilder r)
                {
                    s.PacientProperty_Validate(r);
                }
                private static void _PacientProperty_OnValueChanged(global::LightSwitchApplication.NewPacient s)
                {
                    s.PacientProperty_Changed();
                }

            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class CommandSetProperties
            {
            }

            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal sealed class MethodSetProperties
            {
            }
        }
    }
}
