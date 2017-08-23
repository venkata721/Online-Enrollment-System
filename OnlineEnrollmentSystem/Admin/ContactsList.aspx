<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ContactsList.aspx.cs" Inherits="OnlineEnrollmentSystem.Admin.ContactsList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
          <tr>
              <td>
                 
              </td>
              <td></td>
          </tr>
        <tr>
            <td>
                <asp:GridView ID="gvContacts" runat="server" class="table" AutoGenerateColumns="false" AutoGenerateEditButton="True" OnRowCancelingEdit="gvContacts_RowCancelingEdit" OnRowEditing="gvContacts_RowEditing" OnRowUpdating="gvContacts_RowUpdating">
                    <Columns>
                        <asp:TemplateField HeaderText="CMid" Visible="false">
                            <ItemTemplate>
                                <asp:Label runat="server" ID="lblContactMsgId" Text='<%#Eval("CM_ID") %>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Name">
                            <ItemTemplate>
                                <%#Eval("CM_FullName") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email">
                            <ItemTemplate>
                                <%#Eval("CM_Email") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Phone Number">
                            <ItemTemplate>
                                <%#Eval("CM_PhoneNumber") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Message">
                            <ItemTemplate>
                                <%#Eval("CM_Message") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Send Date">
                            <ItemTemplate>
                                <%#Eval("PostDate") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Replay">
                            <ItemTemplate>
                                <%#Eval("CM_AdminMessage") %>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="txtReplay" runat="server" Text='<%#Eval("CM_AdminMessage") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Replay Date" Visible="false">
                            <ItemTemplate>
                                <%#Eval("ReplayDate") %>
                            </ItemTemplate>
                        </asp:TemplateField>                         
                    </Columns>
                </asp:GridView>
            </td>
            <td>
               
            </td>
        </tr>
    </table>
</asp:Content>
