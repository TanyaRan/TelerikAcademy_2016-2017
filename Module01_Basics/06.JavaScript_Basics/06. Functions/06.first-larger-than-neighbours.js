function solve(args) {
    var i,
    len = +args[0],
        numbers = args[1].split(' ');

        console.log(FirstLargerThanNeighbours(numbers, len));

    function FirstLargerThanNeighbours(numbers, length){
        for (i = 1; i < length - 1; i+=1)
        {
            if (+numbers[i] > +numbers[i - 1] && +numbers[i] > +numbers[i + 1])
            {
                return i;
            }
        }

        return -1;
    }
}
