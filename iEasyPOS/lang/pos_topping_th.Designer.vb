﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class pos_topping_th
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("iEasyPOS.pos_topping_th", GetType(pos_topping_th).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ปุ่มรายการ.
        '''</summary>
        Friend Shared ReadOnly Property _event() As String
            Get
                Return ResourceManager.GetString("event", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ลบรายการ Topping.
        '''</summary>
        Friend Shared ReadOnly Property delTopping() As String
            Get
                Return ResourceManager.GetString("delTopping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to หมายเหตุ.
        '''</summary>
        Friend Shared ReadOnly Property note() As String
            Get
                Return ResourceManager.GetString("note", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ไม่เพิ่ม Topping.
        '''</summary>
        Friend Shared ReadOnly Property noTopping() As String
            Get
                Return ResourceManager.GetString("noTopping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ราคา.
        '''</summary>
        Friend Shared ReadOnly Property price() As String
            Get
                Return ResourceManager.GetString("price", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ยืนยันการทำรายการ.
        '''</summary>
        Friend Shared ReadOnly Property save() As String
            Get
                Return ResourceManager.GetString("save", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to เลือก Topping.
        '''</summary>
        Friend Shared ReadOnly Property selecttopping() As String
            Get
                Return ResourceManager.GetString("selecttopping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to หมวดย่อย Topping.
        '''</summary>
        Friend Shared ReadOnly Property subCatetopping() As String
            Get
                Return ResourceManager.GetString("subCatetopping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ท็อปปิ้ง.
        '''</summary>
        Friend Shared ReadOnly Property topping() As String
            Get
                Return ResourceManager.GetString("topping", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รายการ Topping.
        '''</summary>
        Friend Shared ReadOnly Property toppingList() As String
            Get
                Return ResourceManager.GetString("toppingList", resourceCulture)
            End Get
        End Property
    End Class
End Namespace