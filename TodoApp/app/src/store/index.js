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
    getData(context){
      fetch('https://localhost:5001/api/task')
  .then(response => response.json())
  .then(data => context.commit("setCurrentData",data));
    }
  },
  modules: {
  },
  getters: {
    
  }
})
