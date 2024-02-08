export interface IPoster {
    posterId: string,
    path: string,
    movieId: string,
}

export interface IMovie {
    movieId: string,
    name: string,
    date: number,
    length: number,
    rating: string,
    overView: string,
    poster: IPoster,
}