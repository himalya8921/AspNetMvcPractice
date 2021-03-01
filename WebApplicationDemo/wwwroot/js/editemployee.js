
function validate() {

    var isValid = true;
    var numberRegex = "/^[0-9]^$/";
    $("#Age_ErrorMessage").text("");
    $("#Name_ErrorMessage").text("");
    $("#Desig_ErrorMessage").text("");
    $("#Salary_ErrorMessage").text("");



    console.log(isValid);
    if ($("#Name").val().trim() == "") {
        $("#Name_ErrorMessage").text("Name is required");
        isValid = false;
    }

    if ($("#Age").val().trim() == "") {
        $("#Age_ErrorMessage").text("Age is required");
        isValid = false;
    }

    if ($("#Age").val().trim() == "" && !numberRegex.test($("#Age").val().trim())) {
        $("#Age_ErrorMessage").text("Age is Invalid");
        isValid = false;
    }

    if ($("#Designation").val().trim() == "") {
        $("#Desig_ErrorMessage").text("Designation is required");
        isValid = false;
    }

    if ($("#Salary").val().trim() == "") {
        $("#Salary_ErrorMessage").text("Salary is required");
        isValid = false;
    }





    return isValid;
}


function SubmitForm() {
    if (validate()) {
        $("#EmployeeForm").submit();
    }
}


