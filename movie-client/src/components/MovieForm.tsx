import React, {MouseEvent, useState} from "react";
import {v4} from "uuid";

const MovieForm = () => {
    const [movieName, setMovieName] = useState<string>("");
    const [movieYear, setMovieYear] = useState<number>();
    const [rating, setRating] = useState<string>("");
    const [movieLength, setMovieLength] = useState<number>();
    const [overView, setOverView] = useState<string>("");

    const handleChange = (event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>) : void => {
        event.preventDefault();
        switch (event.currentTarget.name) {
            case "movieName":
                setMovieName(event.currentTarget.value);
                break;
            case "movieYear":
                setMovieYear(parseInt(event.currentTarget.value));
                break;
            case "rating":
                setRating(event.currentTarget.value);
                break;
            case "movieLength":
                setMovieLength(parseInt(event.currentTarget.value));
                break;
            case "overView":
                setOverView(event.currentTarget.value);
                break;
        };
    };

    const handleMovieForm = async (event : MouseEvent) => {
        event?.preventDefault();
        const movieData = {
            MovieId: v4(),
            Name: movieName,
            Date: movieYear,
            Length: movieLength,
            Rating: rating,
            OverView: overView
        };
        console.log(movieData);
        // const options = {
        //     method: "POST",
        //     mode: 'cors',
        //     body: JSON.stringify(movieData),
        //     headers: {
        //         "Content-Type": "application/json",
        //     },
        // };
        await fetch("https://localhost:5001/api/movies", { method: "POST", mode: "cors", body: JSON.stringify(movieData)})
    };

    return(
        <div>
            <form className="formContainer">
                <h2> Movie Entry</h2>
                <label htmlFor="movieName">Name</label>
                <input 
                    name="movieName"
                    type="text"
                    onChange={handleChange}
                />
                <label htmlFor="movieYear">Release Year</label>
                <input 
                    name="movieYear"
                    type="number"
                    min="1888"
                    max="2024"
                    onChange={handleChange}
                />
                <label htmlFor="rating">Rating</label>
                <select name="rating" onChange={handleChange}>
                    <option value="G">G</option>
                    <option value="PG">PG</option>
                    <option value="PG-13">PG-13</option>
                    <option value="R">R</option>
                    <option value="NR" selected>NR</option>
                </select>
                <label htmlFor="movieLength"> Run Time</label>
                <input 
                    name="movieLength"
                    type="number"
                    min="0"
                    onChange={handleChange}
                />
                <textarea 
                    name="overView" 
                    onChange={handleChange} 
                    placeholder="Enter the movie synopsis"
                />
                <button onClick={handleMovieForm} type="submit">Submit</button>
            </form>
        </div>
    )
}

export default MovieForm