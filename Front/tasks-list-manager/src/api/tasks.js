import axios from 'axios';

axios.defaults.baseURL = 'https://localhost:5001/api/'
axios.defaults.headers.put['Access-Control-Allow-Origin'] = '*'
axios.defaults.headers.put['Content-Type'] = 'application/json'

const endPoint = 'tasks';
const Tasks = () => { };

Tasks.GetAll = async (total) => {
	const { data } = await axios.get(`${endPoint}?count=${total}`)	
	return data
}
     
Tasks.CompleteTask = async (entity) => {
	const { data } = await axios.put(`${endPoint}`, entity)
	if (data) {
		return data
	}
}
export default Tasks;