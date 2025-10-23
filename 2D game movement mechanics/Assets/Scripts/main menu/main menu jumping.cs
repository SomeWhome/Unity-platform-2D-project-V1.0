using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class mainmenujumping : MonoBehaviour
{
    public Animator animator;

        private void Start()
        {
            PlayAnimation("Main Menu character");
        }
        public void PlayAnimation(string mainmenu)
    {
        animator.Play(mainmenu);
    }
}

