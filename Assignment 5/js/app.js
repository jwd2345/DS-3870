$('#btnTest').click(function() {
    const decTaxRate = .0925;
    let decHours = $('#txtHours').val();
    let decRate = $('#txtPayRate').val();
    console.log(decRate * decHours);
});
$('#cboEmployeeType').change(function() {
    if($('#cboEmployeeType').val() == 'Full') {
            //$('#divhours').slideUp();
            //$('#divhours').css('display','none');
            $('#divhours').addClass('d-none');
    } else {
        $('#divhours').removeClass('d-none').slideDown();
}
))
