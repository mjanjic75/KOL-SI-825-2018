<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="PresentationLayerWeb.WebFormStudents" %>

<asp:Content ID="StudentsContent" ContentPlaceHolderID="MainContent" runat="server">

	<div class="container">
		<div class="row">
			<div class="col-lg-5 text-center border-1">
				<asp:ListBox ID="ListBoxStudent" runat="server" Height="200px" CssClass="bg-light w-80" Rows="10"></asp:ListBox><br />
				<br />
				<asp:Label ID="LabelStudentFilterByAverageMark" runat="server" Text="Minimalan prosek:"></asp:Label><br />
				<asp:TextBox ID="TextBoxStudentFilterByAverageMark" runat="server"></asp:TextBox><br />
				<br />
				<asp:Button ID="ButtonStudentRefreshListBoxStudent" class="btn btn-lg btn-success" runat="server" Text="Osveži listu studenata" OnClick="ButtonStudentRefreshListBoxStudent_Click" /><br />
				<asp:Label ID="LabelMessages" CssClass="text-success" runat="server" Text=""></asp:Label>
			</div>
			<div class="col-lg-7 text-center border-1">
				<asp:Label ID="LabelStudentName" runat="server" Text="Ime: "></asp:Label><br />
				<asp:TextBox ID="TextBoxStudentName" class="validate-input" runat="server" placeholder="Marko Markovic"></asp:TextBox><br />
				<br />

				<asp:Label ID="LabelStudentIndexNumber" runat="server" Text="Broj indeksa: "></asp:Label><br />
				<asp:TextBox ID="TextBoxStudentIndexNumber" class="validate-input" runat="server" placeholder="123/2020" pattern="^[1-9]?[0-9]{2}\/2[0-9]{3}$"></asp:TextBox><br />
				<br />

				<asp:Label ID="LabelStudentEmail" runat="server" Text="Email: "></asp:Label><br />
				<asp:TextBox ID="TextBoxStudentEmail" class="validate-input" runat="server" placeholder="123-2020@ftn.edu.rs" pattern="^[1-9]?[0-9]{2}-2[0-9]{3}(m|ms)?@ftn\.edu\.rs$"></asp:TextBox><br />
				<br />

				<asp:Label ID="LabelStudentAverageMark" runat="server" Text="Prosečna ocena: "></asp:Label><br />
				<asp:TextBox ID="TextBoxStudentAverageMark" class="validate-input" runat="server" placeholder="5.00"></asp:TextBox><br />
				<br />
				<asp:Button ID="ButtonStudentInsert" class="btn btn-lg btn-primary" runat="server" Text="Unesi podatke o studentu" OnClick="ButtonStudentInsert_Click" />
			</div>
		</div>
	</div>

	<script>
		var inputs = document.getElementsByClassName("validate-input");
		Array.from(inputs).forEach((e) => {
			e.addEventListener("input", () => {
				if (e.value == "") {
					e.style.background = "#FF827D";
				} else {
					e.style.background = "white";
				}
			});

			e.addEventListener("click", () => {
				Array.from(inputs).forEach((e) => {
					if (e.value == "") {
						e.style.background = "#FF827D";
					} else {
						e.style.background = "white";
					}
				});
			});
		});
	</script>

</asp:Content>
