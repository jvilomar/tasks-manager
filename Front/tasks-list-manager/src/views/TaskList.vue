<template>
  <div class="mx-auto">
    <v-card class="mx-auto" max-with="830" outlined shaped tile>
      <v-toolbar color="indigo" dark>
        <v-app-bar-nav-icon></v-app-bar-nav-icon>

        <v-toolbar-title>My Tasks ( {{tasksList.length}} )</v-toolbar-title>

        <v-spacer></v-spacer>
        <v-btn icon>
          <v-icon>mdi-magnify</v-icon>
        </v-btn>
      </v-toolbar>
      <v-divider></v-divider>
      <v-card>
        <v-card-text>
         <v-text-field
              v-model="tasksCount"
              color="purple darken-2"
              label="Number of Tasks to Retrieve"
              @blur="loadTasks()"
            ></v-text-field>
        </v-card-text>
      </v-card>
      <v-container fluid>
        <v-row dense>
          <v-col cols="4" v-for="task in tasksList" :key="task.id">
            <task-detail :task="task" @updateTask="completeTask(task)"/>
          </v-col>
        </v-row>
      </v-container>
    </v-card>
  </div>
</template>

<script>
import Vue from "vue";
import TaskDetail from "../components/TaskDetail.vue";
import Tasks from "../api/tasks";

export default Vue.extend({
  name: "TaskList",
  components: {
    TaskDetail,
  },
  data() {
    return {
      tasksList:[],
      tasksCount : 3
    };
  },
  methods:{
    loadTasks : async function() {
      this.tasksList = await Tasks.GetAll(this.tasksCount);
    },
    completeTask: async function(item){
      let task = {
        id: item.id,
        title: item.title,
        description: item.description,
        isCompleted: true
      }

      await Tasks.CompleteTask(task);
      this.loadTasks();
    },
  },
  created() {
    this.loadTasks();
  }
});
</script>
