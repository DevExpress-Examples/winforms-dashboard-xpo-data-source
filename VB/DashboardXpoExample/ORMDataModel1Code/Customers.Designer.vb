﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Reflection
Namespace DashboardXpoExample.nwind

    <Persistent("Customer")>
    Partial Public Class Customers
        Inherits XPLiteObject
        Dim fAddress As String
        <Size(60)>
        Public Property Address() As String
            Get
                Return fAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Address), fAddress, value)
            End Set
        End Property
        Dim fCity As String
        <Indexed(Name:="City")>
        <Size(15)>
        Public Property City() As String
            Get
                Return fCity
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(City), fCity, value)
            End Set
        End Property
        Dim fCompanyName As String
        <Indexed(Name:="CompanyName")>
        <Size(40)>
        Public Property CompanyName() As String
            Get
                Return fCompanyName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(CompanyName), fCompanyName, value)
            End Set
        End Property
        Dim fContactName As String
        <Size(30)>
        Public Property ContactName() As String
            Get
                Return fContactName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(ContactName), fContactName, value)
            End Set
        End Property
        Dim fContactTitle As String
        <Size(30)>
        Public Property ContactTitle() As String
            Get
                Return fContactTitle
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(ContactTitle), fContactTitle, value)
            End Set
        End Property
        Dim fCountry As String
        <Size(15)>
        Public Property Country() As String
            Get
                Return fCountry
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Country), fCountry, value)
            End Set
        End Property
        Dim fCustomerID As String
        <Key()>
        <Size(5)>
        <Persistent("Id")>
        Public Property CustomerID() As String
            Get
                Return fCustomerID
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(CustomerID), fCustomerID, value)
            End Set
        End Property
        Dim fFax As String
        <Size(24)>
        Public Property Fax() As String
            Get
                Return fFax
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Fax), fFax, value)
            End Set
        End Property
        Dim fPhone As String
        <Size(24)>
        Public Property Phone() As String
            Get
                Return fPhone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Phone), fPhone, value)
            End Set
        End Property
        Dim fPostalCode As String
        <Indexed(Name:="PostalCode")>
        <Size(10)>
        Public Property PostalCode() As String
            Get
                Return fPostalCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(PostalCode), fPostalCode, value)
            End Set
        End Property
        Dim fRegion As String
        <Indexed(Name:="Region")>
        <Size(15)>
        Public Property Region() As String
            Get
                Return fRegion
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Region), fRegion, value)
            End Set
        End Property
    End Class

End Namespace
