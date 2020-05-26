import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify'



Vue.config.productionTip = false

new Vue({
  router,
  store,
  vuetify,
    render: h => h(App)
}).$mount('#app');


// Vue.filter('formatDate', function(value) {
//   if (value) {
//     return moment(String(value)).format('MM/DD/YYYY hh:mm')
//   }
// },
// Vue.filter('changeDate', function(value){
//   return moment(String(value)).format('MMMM Do YYYY, h:mm:ss a')
//   }))
