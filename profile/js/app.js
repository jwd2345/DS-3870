var arrProfileData;
$.gtJSON(https://www.swollenhippo.com/getProfileDetailsByAPIKey.php?APIKey=DuffManSays,Phrasing!&Codename=DuffMan)
console.log.(result);
arrProfileData = result;
fillProfile(arrProfileData[0]);
})

function fillProfile(Employee){
    $('txtEmployeeName').text(Employee.FirstName)
}
