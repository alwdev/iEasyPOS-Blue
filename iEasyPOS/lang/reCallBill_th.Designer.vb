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
    Friend Class reCallBill_th
        
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
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("iEasyPOS.reCallBill_th", GetType(reCallBill_th).Assembly)
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
        '''  Looks up a localized string similar to วันที่ค้นหา.
        '''</summary>
        Friend Shared ReadOnly Property _date() As String
            Get
                Return ResourceManager.GetString("date", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ค้นบิล.
        '''</summary>
        Friend Shared ReadOnly Property bill() As String
            Get
                Return ResourceManager.GetString("bill", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to วันที่.
        '''</summary>
        Friend Shared ReadOnly Property datadate() As String
            Get
                Return ResourceManager.GetString("datadate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ยอดรวม.
        '''</summary>
        Friend Shared ReadOnly Property datatotal() As String
            Get
                Return ResourceManager.GetString("datatotal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ลบการขาย.
        '''</summary>
        Friend Shared ReadOnly Property deleteSale() As String
            Get
                Return ResourceManager.GetString("deleteSale", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ส่วนลด.
        '''</summary>
        Friend Shared ReadOnly Property discount() As String
            Get
                Return ResourceManager.GetString("discount", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to จ่ายโดย.
        '''</summary>
        Friend Shared ReadOnly Property paymentType() As String
            Get
                Return ResourceManager.GetString("paymentType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ราคาสินค้า.
        '''</summary>
        Friend Shared ReadOnly Property price() As String
            Get
                Return ResourceManager.GetString("price", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to พิมพ์ใบเสร็จ.
        '''</summary>
        Friend Shared ReadOnly Property Print() As String
            Get
                Return ResourceManager.GetString("Print", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รหัสสินค้า.
        '''</summary>
        Friend Shared ReadOnly Property productCode() As String
            Get
                Return ResourceManager.GetString("productCode", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รายการสินค้า.
        '''</summary>
        Friend Shared ReadOnly Property productName() As String
            Get
                Return ResourceManager.GetString("productName", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to จำนวน.
        '''</summary>
        Friend Shared ReadOnly Property qty() As String
            Get
                Return ResourceManager.GetString("qty", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to เลขที่การขาย.
        '''</summary>
        Friend Shared ReadOnly Property saleno() As String
            Get
                Return ResourceManager.GetString("saleno", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ค้นหา.
        '''</summary>
        Friend Shared ReadOnly Property search() As String
            Get
                Return ResourceManager.GetString("search", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รวม.
        '''</summary>
        Friend Shared ReadOnly Property subTotal() As String
            Get
                Return ResourceManager.GetString("subTotal", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รวมทั้งหมด.
        '''</summary>
        Friend Shared ReadOnly Property total() As String
            Get
                Return ResourceManager.GetString("total", resourceCulture)
            End Get
        End Property
    End Class
End Namespace