<%@ Page Language="C#" MasterPageFile="~/admin/admin_Master.master" AutoEventWireup="true" CodeFile="5bill_details.aspx.cs" Inherits="admin_5bill_details" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>

 <table style="border-right: maroon thick groove; border-top: maroon thick groove;
        border-left: maroon thick groove; width: 100%; border-bottom: maroon thick groove" id="TABLE1" onclick="return TABLE1_onclick()">
     <tr>
         <td colspan="2" style="background-color: white; text-align: center; height: 21px;">
         </td>
     </tr>
                                        <tr>
                                            <td colspan="2" style="background-color: white; text-align: center">
                                                <span style="color: Black; font-family: Georgia"><strong>Bill &nbsp;Details</strong></span></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="background-color: white; text-align: right">
                                                <span style="color: #ff3333"><strong><span style="color: black">.</span></strong></span></td>
                                        </tr>
     <tr>
         <td align="right" style="width: 25%; height: 24px">
             <strong>Bill No:</strong></td>
         <td align="left" style="width: 70%; height: 24px">
             <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
                 DataTextField="bill_no" DataValueField="bill_no" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                 SelectCommand="SELECT [bill_no] FROM [bill_master]"></asp:SqlDataSource>
         </td>
     </tr>
                                        <tr>
                                            <td align="right" style="width: 25%; height: 24px;">
                                                <strong>Source :</strong></td>
                                            <td align="left" style="width: 70%; height: 24px;">
                                                <asp:TextBox ID="txtsource" runat="server" Width="159px" ReadOnly="True" AutoPostBack="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%">
                                                <strong>Destination:</strong></td>
                                            <td align="left" style="width: 70%">
                                                <asp:TextBox ID="txtdesti" runat="server" Width="159px" ReadOnly="True" AutoPostBack="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%">
                                                <strong>Date Of Journey: </strong>
                                            </td>
                                            <td align="left" style="width: 70%">
                                                <asp:TextBox ID="txtdate" runat="server" Width="219px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%">
                                                <strong>Time Of Journey:</strong></td>
                                            <td align="left" style="width: 70%">
                                                <asp:TextBox ID="txttime" runat="server" Width="215px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
     <tr>
         <td align="right" style="width: 25%; height: 21px;">
             <strong>Bus Type:</strong></td>
         <td align="left" style="width: 70%; height: 21px;">
             <asp:TextBox ID="txtbustype" runat="server" Width="149px" ReadOnly="True"></asp:TextBox></td>
     </tr>
     <tr>
         <td align="right" style="width: 25%; height: 21px">
             <strong>Seat Numbers:</strong></td>
         <td align="left" style="width: 70%; height: 21px">
             <asp:TextBox ID="Txtseatnos" runat="server" Width="387px" ReadOnly="True"></asp:TextBox></td>
     </tr>
     <tr>
         <td align="right" style="width: 25%; height: 21px">
             <strong>Total Bill:</strong></td>
         <td align="left" style="width: 70%; height: 21px">
             <asp:TextBox ID="Txttotalbill" runat="server" Width="153px" ReadOnly="True"></asp:TextBox></td>
     </tr>
     <tr>
         <td align="left" colspan="2" style="height: 12px">
         </td>
     </tr>
                                        <tr>
                                            <td align="left" colspan="2" style="height: 28px; vertical-align: top; text-align: center;">
                                                
                                                <asp:Button ID="btnpvs" runat="server" BackColor="Gray" Font-Bold="True"
                                                    ForeColor="WhiteSmoke" Height="23px" OnClick="btnpvs_Click" Style="color: #000000;
                                                    background-color: skyblue" Text="NEXT" Width="95px" />
                                                &nbsp; &nbsp; &nbsp; &nbsp; 
                                                <asp:Button ID="btnnext" runat="server" BackColor="Gray"
                                                    Font-Bold="True" ForeColor="WhiteSmoke" Height="23px" OnClick="btnnext_Click"
                                                    Style="color: #000000; background-color: skyblue" Text="PREVIOUS" Width="95px" />
                                                &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="FIRST"
                                                    Width="91px" />
                                                &nbsp;&nbsp;
                                                <asp:Button ID="Button2" runat="server" Text="LAST" Width="83px" />
                                                &nbsp; &nbsp;
                                                <asp:Button ID="Button3" runat="server" Text="DELETE" Width="85px" />
                                                &nbsp; &nbsp;
                                                &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            </td>
                                        </tr>
                                    </table>
</asp:Content>

