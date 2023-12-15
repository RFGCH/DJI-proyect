using UnityEngine;
using UnityEngine.Networking;
using System.Collections.Generic;

using Windows.Kinect;
using Joint = Windows.Kinect.Joint;

public class BodySourceView : MonoBehaviour
{
    public BodySourceManager mBodySourceManager;
    public GameObject mJointObject;
    private Dictionary<ulong, GameObject> mBodies = new Dictionary<ulong, GameObject>();

    //Vectores para representacion
    public Vector3 hand1Position;
    public Vector3 hand2Position;

    private List<JointType> _joints = new List<JointType>
    {
        JointType.HandLeft,
        JointType.HandRight,
    };
    void Update()
    {
        #region Get Kinect data
        Body[] data = mBodySourceManager.GetData();
        if (data == null)
            return;

        List<ulong> trackedIds = new List<ulong>();
        foreach (var body in data)
        {
            if (body == null)
                continue;

            if (body.IsTracked)
                trackedIds.Add(body.TrackingId);
        }
        #endregion

        #region Delete Kinect bodies
        List<ulong> knownIds = new List<ulong>(mBodies.Keys);
        foreach (ulong trackingId in knownIds)
        {
            if (!trackedIds.Contains(trackingId))
            {
                // Destroy body object
                Destroy(mBodies[trackingId]);

                // Remove from list
                mBodies.Remove(trackingId);
            }
        }
        #endregion

        #region Create Kinect bodies
        foreach (var body in data)
        {
            // If no body, skip
            if (body == null)
                continue;

            if (body.IsTracked)
            {
                // If body isn't tracked, create body
                if (!mBodies.ContainsKey(body.TrackingId))
                    mBodies[body.TrackingId] = CreateBodyObject(body.TrackingId);

                // Update positions
                UpdateBodyObject(body, mBodies[body.TrackingId]);
            }
        }
        #endregion
        //Debug.Log("Posición de Hand1: " + hand1Position);
        //Debug.Log("Posición de Hand2: " + hand2Position);
    }

    private GameObject CreateBodyObject(ulong id)
    {
        // Create body parent
        GameObject body = new GameObject("Body:" + id);

        // Create joints
        foreach (JointType joint in _joints)
        {
            // Create Object
            GameObject newJoint = Instantiate(mJointObject);
            newJoint.name = joint.ToString();

            // Add tags to the first two joints
            if (joint == _joints[0])
            {
                newJoint.tag = "Hand1";
            }
            else if (joint == _joints[1])
            {
                newJoint.tag = "Hand2";
            }

            // Parent to body
            newJoint.transform.parent = body.transform;
        }

        return body;
    }

    private void UpdateBodyObject(Body body, GameObject bodyObject)
    {
        // Update joints
        foreach (JointType _joint in _joints)
        {
            // Get new target position
            Joint sourceJoint = body.Joints[_joint];
            Vector3 targetPosition = GetVector3FromJoint(sourceJoint);
            targetPosition.z = -3;

            // Get joint, set new position
            Transform jointObject = bodyObject.transform.Find(_joint.ToString());
            jointObject.position = targetPosition;

            // Si es "Hand1", asigna la posición a hand1Position
            if (jointObject.CompareTag("Hand1"))
            {
                hand1Position = targetPosition;
            }
            // Si es "Hand2", asigna la posición a hand2Position
            else if (jointObject.CompareTag("Hand2"))
            {
                hand2Position = targetPosition;
            }
        }
    }
    public Vector3 GetHand1()
    {
       return hand1Position;
    }
    private Vector3 GetVector3FromJoint(Joint joint)
    {
        return new Vector3(joint.Position.X * 10, joint.Position.Y * 10, joint.Position.Z * 10);
    }
}
