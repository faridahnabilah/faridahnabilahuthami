<%@ Page Language="C#" MasterPageFile="~/admin/admin_Master.master" AutoEventWireup="true" CodeFile="1_route.aspx.cs" Inherits="admin_1_route" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table style="border-right: maroon thick groove; border-top: maroon thick groove;
        border-left: maroon thick groove; width: 100%; border-bottom: maroon thick groove">
       <tr>
           <td align="left" colspan="2" style="font-weight: bold; vertical-align: middle; text-transform: capitalize;
               width: 100%; height: 25px; text-align: justify">
           </td>
       </tr>
        <tr>
            <td align="left" colspan="2" style="font-weight: bold; text-transform: capitalize;
                width: 100%; height: 5px; vertical-align: middle; text-align: center; font-size: 20px;">
                Route Entry<br />
            </td>
        </tr>
         <tr>
             <td align="left" colspan="2" style="font-weight: bold; text-transform: capitalize;
                 width: 100%; height: 11px" class="hedtd">
             </td>
         </tr>
        <tr>
            <td align="right" style="font-weight: bold; text-transform: capitalize; width: 30%;
                ">
                Route Id:</td>
            <td align="left" style="width: 50%">
                &nbsp;<asp:DropDownList ID="ddlrouteid" runat="server" Style="position: static" Width="98px" DataSourceID="SqlDataSource1" DataTextField="route_id" DataValueField="route_id" AutoPostBack="True" OnSelectedIndexChanged="ddlrouteid_SelectedIndexChanged">
                    <asp:ListItem>Select one...</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="txtrouteid" runat="server" Visible="False" Width="75px" OnTextChanged="txtrouteid_TextChanged"></asp:TextBox>&nbsp;</td>
        </tr>
        <tr>
            <td align="right" style="font-weight: bold; text-transform: capitalize; width: 30%;
              height: 26px;">
                <span>&nbsp;From:</span></td>
            <td align="left" style="width: 50%; height: 26px;">
                <asp:TextBox ID="txtfrom" runat="server" Width="221px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="font-weight: bold; text-transform: capitalize; width: 30%;
              height: 25px;">
                <span>&nbsp;To<span style="color: #800000"></span> :</span></td>
            <td align="left" style="width: 50%; height: 25px;">
                    <asp:TextBox ID="txtto" runat="server" Width="221px"></asp:TextBox></td>
        </tr>
       <tr>
           <td align="left" colspan="2" style="vertical-align: middle; height: 11px; text-align: center">
           </td>
       </tr>
        <tr>
            <td align="left" colspan="2" style="height: 32px; vertical-align: middle; text-align: center;">
                <asp:Button ID="btnaddroute" runat="server" Font-Bold="True" OnClick="BtnAdd_Click" Style="background-color: skyblue"
                    Text="ADD" Width="95px" />
                &nbsp;&nbsp; &nbsp;<asp:Button ID="btnsave" runat="server" Text="SAVE" Width="89px" Style="background-color: skyblue" Font-Bold="True" OnClick="btnsave_Click" />
                <asp:Button ID="btndelroute" runat="server" BackColor="Gray" Font-Bold="True" ForeColor="WhiteSmoke"
                    Height="23px" Style="color: #000000; background-color: skyblue" Text="DELETE"
                    Width="95px" OnClick="btndelroute_Click" />
                <asp:Button ID="btnupdate" runat="server" BackColor="Gray" Font-Bold="True" ForeColor="WhiteSmoke"
                    Height="23px" OnClick="btnupdate_Click" Style="color: #000000; background-color: skyblue"
                    Text="MODIFY" Width="95px" />&nbsp;</td>
        </tr>
        <tr>
            <td align="right" style="font-weight: bold; text-transform: capitalize;
               height: 28px;" colspan="2">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server"
                    ConnectionString="<%$ ConnectionStrings:ConnectionString %>" DeleteCommand="DELETE FROM [route_master] WHERE [route_id] = @original_route_id"
                    OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [route_id] FROM [route_master]">
                    <DeleteParameters>
                        <asp:Parameter Name="original_route_id" Type="Int32" />
                    </DeleteParameters>
                </asp:SqlDataSource>
                &nbsp;&nbsp;
            </td>
        </tr>
    </table>
</asp:Content>

