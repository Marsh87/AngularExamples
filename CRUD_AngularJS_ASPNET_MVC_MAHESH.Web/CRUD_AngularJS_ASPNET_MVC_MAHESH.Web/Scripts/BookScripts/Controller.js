app.controller("bookController", function($scope, bookService) {
    $scope.divBook = false;
    GetAllBooks();
    function GetAllBooks() {
        debugger;
        var getBookData = bookService.getBooks();
        getBookData.then(function(book) {
            $scope.books = book.data;
        }, function() {
            alert('Error in getting book records');
        });
    }

    $scope.editBook=function(book) {
        var getBookData = bookService.getBook(book.Id);
        getBookData.then(function(_book) {
                $scope.book = _book.data;
                $scope.bookId = book.Id;
                $scope.bookTitle = book.Title;
                $scope.bookAuthor = book.Author;
                $scope.bookPublisher = book.Publisher;
                $scope.bookIsbn = book.Isbn;
                $scope.Action = "Update";
                $scope.divBook = true;
            },
            function() {
                alert('Error in getting book records');
            });
    }



});