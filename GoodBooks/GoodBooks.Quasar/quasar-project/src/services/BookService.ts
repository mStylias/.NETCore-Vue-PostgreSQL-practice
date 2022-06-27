import axios from 'axios'
import IBook from 'src/types/Book';

export default class BookService {
  API_URL = 'https://localhost:7149/api';

  public async getAllBooks(): Promise<IBook[]> {
    const result = await axios.get(`${this.API_URL}/books/`);
    console.log(result);
    return result.data;
  }
}
