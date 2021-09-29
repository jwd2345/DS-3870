$.getJSON("https://www.swollenhippo.com/getProfileDetailsByAPIKey.php?APIKey=DuffManSays,Phrasing!&Codename=Duchess", function(result){
    $.each(result,function(i,person){
    arrProfile = result;
    $.each(result,function(i,person){

    })

    })
})

function buildEmployeeCard(Profile){
    strCardHTML = '<div class="card col-3 mt-3 ml-3 mb-3">';
    strCardHTML += '<div class="card-body">';
    strCardHTML += '<img src="https://www.swollenhippo.com/archer.jpg" alt="Profile Pic" style="width:100%; border-radius: 50%;"></img>';
    strCardHTML += '<h2 class="text-center mb-0">' + Profile.FirstName + ' ' + Profile.LastName + '</h2>';
    strCardHTML += '<h4 class="text-center text-muted mt-0">' + Profile.CodeName + '</h4>';
    strCardHTML += '<h5 class="mt-5 text-bold">Contact Details</h5>';
    strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.Agency + '</h5>'
    strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.Job + '</h5>'
    strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.HireDate + '</h5>'
    strCardHTML += '</div>'
function buildEmployeeCard(ContactDetails){
    function buildEmployeeCard(Profile){
        strCardHTML = '<div class="card col-3 mt-3 ml-3 mb-3">';
        strCardHTML += '<div class="card-body">';

        strCardHTML += '<h2 class="text-center mb-0">' + Profile.Email + '</h5>';
        strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.Phone + '</h5>'
        strCardHTML += '</div>';
        strCardHTML += '</div>';
        strCardHTML += '<h5 class="text-center text-muted mt-0">' + Profile.StreetAddress1 + '</h5>';
        strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.City + '</h5>'
        strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.State + '</h5>'
        strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.ZipCode + '</h5>'
        strCardHTML += '</div>';
        strCardHTML += '</div>';
        strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.EmergencyContact + '</h5>'
        strCardHTML += '<h5 class="mt-5 text-center">'+ Profile.Phone + '</h5>'

    $.getJSON("gethttps://www.swollenhippo.com/getPayStubsByAPIKey.php. =DuffManSays,Phrasing!", function(result){
    $.each(result,function(i,person){
    arrProfile = result;
    $.each(result,function(i,person){