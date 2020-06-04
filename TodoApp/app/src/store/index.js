import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
  
    tasks:[]
  },
  mutations: {
    setCurrentData(state,data){
        state.tasks=data;
       
    }
    
  },
  actions: {

    createData(context,data){
      fetch('https://localhost:5001/api/task',{
      method:"post",
      headers: {
        'Content-Type': 'application/json'
        // 'Content-Type': 'application/x-www-form-urlencoded',
      },
      body: JSON.stringify(data)})
  .then(response => response.json())
  .then(data => context.commit("setCurrentData",data));
    },
    getData(context){
      fetch('https://localhost:5001/api/task')
  .then(response => response.json())
  .then(data => context.commit("setCurrentData",data));
    },
    deleteData(context,id){
      fetch(`https://localhost:5001/api/task/${id}`,{
        method:"delete",
        
      })
  .then(response => response.json())
  .then(data => context.commit("setCurrentData",data));//context.commit("setCurrentData",data));
    }

  },
  modules: {
  },
  getters: {
    
  }
})
