import axios from 'axios';

export default class clientService {
    static async getClientIncome(clientId: string) {
        const response = await axios.get(`/v1/income/${clientId}`);
        return response.data;
    }
}
